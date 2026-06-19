using Npgsql;
using Project_Akhir.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Akhir.Controllers
{
    internal class LaporanController
    {
        public int GetQuranMingguIni()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi='Al-Quran'
                AND tanggal_donasi >= date_trunc('week', CURRENT_DATE)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetAlatSholatMingguIni()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi = 'Alat Sholat'
                AND tanggal_donasi >=
                date_trunc('week', CURRENT_DATE)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetMakananMinumanMingguIni()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi = 'Makanan/Minuman'
                AND tanggal_donasi >=
                date_trunc('week', CURRENT_DATE)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetUangTunaiMingguIni()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi = 'Uang Tunai'
                AND tanggal_donasi >=
                date_trunc('week', CURRENT_DATE)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetTotalDonasiMingguan(string jenisDonasi, int minggu)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string query = @"SELECT COALESCE(SUM(jumlah),0)
                FROM donasi
                WHERE jenis_donasi = @jenis
                AND (CASE
                WHEN EXTRACT(DAY FROM tanggal_donasi) BETWEEN 1 AND 7 THEN 1
                WHEN EXTRACT(DAY FROM tanggal_donasi) BETWEEN 8 AND 14 THEN 2
                WHEN EXTRACT(DAY FROM tanggal_donasi) BETWEEN 15 AND 21 THEN 3
                ELSE 4
                END) = @minggu";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@jenis", jenisDonasi);
                cmd.Parameters.AddWithValue("@minggu", minggu);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int[] GetChartData(string jenisDonasi)
        {
            int[] data = new int[4];

            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                for (int minggu = 1; minggu <= 4; minggu++)
                {
                    string query = @"SELECT COALESCE(SUM(jumlah),0)
                    FROM donasi
                    WHERE jenis_donasi = @jenis
                    AND (CASE
                    WHEN EXTRACT(DAY FROM tanggal_donasi)
                    BETWEEN 1 AND 7 THEN 1

                    WHEN EXTRACT(DAY FROM tanggal_donasi)
                    BETWEEN 8 AND 14 THEN 2

                    WHEN EXTRACT(DAY FROM tanggal_donasi)
                    BETWEEN 15 AND 21 THEN 3

                    ELSE 4
                    END) = @minggu";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@jenis", jenisDonasi);
                    cmd.Parameters.AddWithValue("@minggu", minggu);

                    data[minggu - 1] = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return data;
        }
    }
}
