using Npgsql;
using Project_Akhir.Database;
using System;
using System.Data;

namespace Project_Akhir.Controllers
{
    internal class InfoDonasiController
    {
        public DataTable GetDonasi()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT d.nama AS ""Nama Donatur"",
                 dn.tanggal_donasi AS ""Tanggal"",
                 dn.jenis_donasi AS ""Jenis Donasi"",
                 dn.jumlah AS ""Jumlah"",
                 dn.satuan AS ""Satuan""
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

        public DataTable CariDonasi(string jenisDonasi)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT d.nama AS ""Nama Donatur"",
                 dn.tanggal_donasi AS ""Tanggal"",
                 dn.jenis_donasi AS ""Jenis Donasi"",
                 dn.jumlah AS ""Jumlah"",
                 dn.satuan AS ""Satuan""
                 FROM donasi dn
                 JOIN donatur d
                 ON dn.id_donatur = d.id_donatur
                 WHERE dn.jenis_donasi ILIKE @jenis";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@jenis", "%" + jenisDonasi + "%");

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
