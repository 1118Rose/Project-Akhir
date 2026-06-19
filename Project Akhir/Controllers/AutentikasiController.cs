using Npgsql;
using Project_Akhir.Database;
using Project_Akhir.Models;

namespace Project_Akhir.Controllers
{ 

    // INTERFACE
    internal class AutentikasiController : IAutentikasi
    {
        public string Login(string username, string password)
        {
            string role = null;

            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query =
                    @"SELECT id_account, role
              FROM accounts
              WHERE username = @username
              AND password = @password";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.IdAccount =
                        Convert.ToInt32(reader["id_account"]);

                    Session.Role =
                        reader["role"].ToString();

                    role = Session.Role;
                }
            }

            return role;
        }

        // METHOD OVERLOADING
        public string Login(User user)
        {
            return Login(user.Username, user.Password);
        }

        public bool Register(
            string email,
            string username,
            string password)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query =
                    @"INSERT INTO accounts
              (username, password, role)
              VALUES
              (@username, @password, 'Donatur')";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        } 
    }
}