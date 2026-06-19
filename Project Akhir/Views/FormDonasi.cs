using Project_Akhir.Controllers;
using Project_Akhir.Helpers;
using Project_Akhir.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Project_Akhir
{
    public partial class FormDonasi : Form
    {
        public FormDonasi()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                Donatur dtr = new Donatur();

                dtr.Nama = txNama.Text;
                dtr.NoTelp = txNoTelp.Text;
                dtr.Email = txEmail.Text;
                if (!txEmail.Text.Contains("@"))
                {
                    MessageBox.Show("Format email tidak valid!");
                    return;
                }

                DateTime tanggalDonasi = DateTime.Now;

                string jenisDonasi = comboJenisDona.Text;
                int jumlah = Convert.ToInt32(txJumlah.Text.Replace(".", "").Replace(",", "")
);
                string tampilJumlah = "";
                string satuan = "";

                switch (jenisDonasi)
                {
                    case "Uang Tunai":
                        satuan = "Rupiah";
                        tampilJumlah = "Rp " + jumlah.ToString("N0");
                        break;

                    case "Al-Quran":
                        satuan = "Buah";
                        tampilJumlah = jumlah + " buah Al-Quran";
                        break;

                    case "Makanan/Minuman":
                        satuan = "Porsi";
                        tampilJumlah = jumlah + " porsi";
                        break;

                    case "Alat Sholat":
                        satuan = "Set";
                        tampilJumlah = jumlah + " set alat sholat";
                        break;

                    default:
                        satuan = "";
                        tampilJumlah = jumlah.ToString();
                        break;
                }

                DonasiController ctrl = new DonasiController();

                ctrl.SimpanDonasi(dtr, jenisDonasi, jumlah, satuan,tanggalDonasi);

                string hasil =
                    "=== DATA DONATUR ===" +
                    "\nHi, " + dtr.Nama + "! Terima kasih atas donasi yang telah Anda berikan." +
                    "\n\nTanggal Donasi : " + tanggalDonasi.ToString("dd/MM/yyyy HH:mm") +
                    "\nNo Telp : " + dtr.NoTelp +
                    "\nEmail : " + dtr.Email +
                    "\nJenis Donasi : " + jenisDonasi +
                    "\nJumlah : " + tampilJumlah +
                    "\n\nSemoga setiap kebaikan yang Anda berikan menjadi amal jariyah dan membawa keberkahan dalam hidup.";

                MessageBox.Show(
                    hasil,
                    "Donasi Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txNama.Clear();
                txNoTelp.Clear();
                txEmail.Clear();
                txJumlah.Clear();

                comboJenisDona.SelectedIndex = 0;

                txNama.Focus();
            }
            catch
            {
                MessageBox.Show(
                    "Mohon isi semua data dengan benar!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            Login frm = new Login ();
            frm.Show();
            this.Hide();
        }

        FormResizer resize = new FormResizer();

        private void Login_Load(object sender, EventArgs e)
        {
            resize.SaveInitialSize(this);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            resize.ResizeControls(this);
        }

    }

}
