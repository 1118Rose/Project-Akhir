using Npgsql;
using Project_Akhir.Database;
using Project_Akhir.Models;
using System;

namespace Project_Akhir.Controllers
{
    internal class DonasiController
    {
        public void SimpanDonasi(Donatur dtr, string jenisDonasi, int jumlah, string satuan, DateTime tanggalDonasi)
        {
            int idDonatur;

            using (NpgsqlConnection conn = new NpgsqlConnection(Koneksi.connString))
            {
                conn.Open();

                string cekDonatur = @"SELECT id_donatur
                FROM donatur
                WHERE id_account = @id_account";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cekDonatur, conn))
                {
                    cmd.Parameters.AddWithValue("@id_account", Session.IdAccount);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        idDonatur = Convert.ToInt32(result);
                    }
                    else
                        {
                            string insertDonatur = @"INSERT INTO donatur (id_account, nama, no_telp, email) VALUES (@id_account, @nama, @no_telp, @email) RETURNING id_donatur";

                            using (NpgsqlCommand cmdInsert =
                                new NpgsqlCommand(insertDonatur, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@id_account", Session.IdAccount);
                                cmdInsert.Parameters.AddWithValue("@nama", dtr.Nama);
                                cmdInsert.Parameters.AddWithValue("@no_telp", dtr.NoTelp);
                                cmdInsert.Parameters.AddWithValue("@email", dtr.Email);

                                idDonatur = Convert.ToInt32(cmdInsert.ExecuteScalar());
                            }
                        }
                    string insertDonasi = @"INSERT INTO donasi (id_donatur, jenis_donasi, jumlah, satuan, tanggal_donasi) VALUES (@id_donatur, @jenis_donasi, @jumlah, @satuan, @tanggal_donasi)";

                    using (NpgsqlCommand cmdDonasi = new NpgsqlCommand(insertDonasi, conn))
                    {
                        cmdDonasi.Parameters.AddWithValue("@id_donatur", idDonatur);
                        cmdDonasi.Parameters.AddWithValue("@jenis_donasi", jenisDonasi);
                        cmdDonasi.Parameters.AddWithValue("@jumlah", jumlah);
                        cmdDonasi.Parameters.AddWithValue("@satuan", satuan);
                        cmdDonasi.Parameters.AddWithValue("@tanggal_donasi", tanggalDonasi);

                        cmdDonasi.ExecuteNonQuery();
                    }
                }
                }
            }
        }
}
