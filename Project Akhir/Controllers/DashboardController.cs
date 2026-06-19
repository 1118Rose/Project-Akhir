using Npgsql;
using Project_Akhir.Database;
using System.Data;

namespace Project_Akhir.Controllers
{
    internal class DashboardController
    {
        public String GetTotalDonatur()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM donatur";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return cmd.ExecuteScalar().ToString();
            }
        }

        public string GetTotalAlQuran()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi='Al-Quran'";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return cmd.ExecuteScalar().ToString();
            }
        }

        public string GetTotalMakanan()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi='Makanan/Minuman'";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return cmd.ExecuteScalar().ToString();
            }
        }

        public string GetTotalAlatSholat()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi='Alat Sholat'";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return cmd.ExecuteScalar().ToString();
            }
        }

        public string GetTotalUangTunai()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi='Uang Tunai'";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return cmd.ExecuteScalar().ToString();
            }
        }
        
        public DataTable GetDonasiTerbaru()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT d.nama, d.email,
                dn.jenis_donasi,
                dn.jumlah,
                dn.tanggal_donasi
                FROM donasi dn
                JOIN donatur d
                ON dn.id_donatur = d.id_donatur
                ORDER BY dn.tanggal_donasi DESC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
