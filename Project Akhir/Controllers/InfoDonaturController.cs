using Npgsql;
using Project_Akhir.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Project_Akhir.Controllers
{
    internal class InfoDonaturController
    {
        public DataTable GetDonatur()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT nama AS ""Nama"", no_telp AS ""No Telp"", email AS ""Email""
                FROM donatur
                ORDER BY nama";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable CariDonatur(string nama)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT nama AS ""Nama"", no_telp AS ""No Telp"", email AS ""Email""
                FROM donatur
                WHERE nama ILIKE @nama";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
