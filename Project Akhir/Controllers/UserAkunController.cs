using Npgsql;
using Project_Akhir.Database;
using System.Data;

namespace Project_Akhir.Controllers
{
    internal class UserAkunController
    {
        public DataTable GetUser()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT a.id_account, d.tanggal_daftar AS ""Tanggal"", d.nama AS ""Nama"", d.email AS ""Email"", d.no_telp AS ""No Telp"", a.role AS ""Role""
                FROM accounts a
                JOIN donatur d
                ON a.id_account = d.id_account
                ORDER BY d.tanggal_daftar DESC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable CariUser(string nama)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT a.id_account, a.tanggal_daftar AS ""Tanggal"", d.nama AS ""Nama"", d.email AS ""Email"", d.no_telp AS ""No Telp"", a.role AS ""Role""
                FROM accounts a
                JOIN donatur d
                ON a.id_account = d.id_account
                WHERE d.nama ILIKE @nama";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public bool DeleteUser(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"
                DELETE FROM donasi
                WHERE id_donatur =
                (
                    SELECT id_donatur
                    FROM donatur
                    WHERE id_account=@id
                );

                DELETE FROM donatur
                WHERE id_account=@id;

                DELETE FROM accounts
                WHERE id_account=@id;";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateUser(int id, string nama, string email, string noTelp, string role)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"UPDATE donatur 
                SET nama=@nama, email=@email,no_telp=@telp
                WHERE id_account=@id;

                UPDATE accounts
                SET role=@role
                WHERE id_account=@id;";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telp", noTelp);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
