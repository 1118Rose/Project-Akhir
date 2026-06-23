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

                string query = @"SELECT d.nama AS ""Nama"", d.no_telp AS ""No Telp"", d.email AS ""Email"", MAX(dn.tanggal_donasi) AS ""Tanggal""
                FROM donatur d
                LEFT JOIN donasi dn
                ON d.id_donatur = dn.id_donatur
                GROUP BY d.nama, d.no_telp, d.email
                ORDER BY d.nama";

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

                string query = @"SELECT d.nama AS ""Nama"", d.no_telp AS ""No Telp"", d.email AS ""Email"",  MAX(dn.tanggal_donasi) AS ""Tanggal""
                FROM donatur d
                LEFT JOIN donasi dn
                ON d.id_donatur = dn.id_donatur
                WHERE d.nama ILIKE @nama
                GROUP BY d.nama, d.no_telp, d.email
                ORDER BY d.nama";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable FilterTanggal(DateTime tanggal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT d.nama AS ""Nama"", d.no_telp AS ""No Telp"", d.email AS ""Email"", MAX(dn.tanggal_donasi) AS ""Tanggal""
                FROM donatur d
                LEFT JOIN donasi dn
                ON d.id_donatur = dn.id_donatur
                WHERE DATE(dn.tanggal_donasi) = @tanggal
                GROUP BY d.nama, d.no_telp, d.email
                ORDER BY d.nama";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@tanggal", tanggal.Date);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
