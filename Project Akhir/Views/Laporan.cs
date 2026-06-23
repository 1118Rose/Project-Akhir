using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Npgsql;
using Project_Akhir.Controllers;
using Project_Akhir.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Project_Akhir
{
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            LaporanController ctrl = new LaporanController();

            lblAlQuranMingguIni.Text = ctrl.GetQuranMingguIni() + " Buah";
            lblAlatSholatMingguIni.Text = ctrl.GetAlatSholatMingguIni() + " Set";
            lblMakananMingguIni.Text = ctrl.GetMakananMinumanMingguIni() + "porsi";
            lblUangTunaiMingguIni.Text = "Rp. " + ctrl.GetUangTunaiMingguIni();

            LoadMingguTerpilih();

            pnlChartBarang.Controls.Clear();

            var chartBarang = new CartesianChart
            {
                Dock = DockStyle.Fill,

                Series = new ISeries[]
                {
            new ColumnSeries<int>
            {
                Name = "Al-Quran",
                Values = ctrl.GetChartData("Al-Quran")
            },

            new ColumnSeries<int>
            {
                Name = "Makanan/Minuman",
                Values = ctrl.GetChartData("Makanan/Minuman")
            },

            new ColumnSeries<int>
            {
                Name = "Alat Sholat",
                Values = ctrl.GetChartData("Alat Sholat")
            },
                }
            };
            chartBarang.XAxes = new[]
            {
                new Axis
                {
                    Labels = new[]
                    {
                        "Minggu 1",
                        "Minggu 2",
                        "Minggu 3",
                        "Minggu 4"
                    }
                }
            };

            pnlChartBarang.Controls.Add(chartBarang);
            pnlChartUangTunai.Controls.Clear();

            var chartUang = new CartesianChart
            {
                Dock = DockStyle.Fill,

                Series = new ISeries[]
                {
            new ColumnSeries<int>
            {
            Name = "Uang Tunai",
            Values = ctrl.GetChartData("Uang Tunai")
            }
                }
            };

            chartUang.XAxes = new[]
            {
            new Axis
            {
                Labels = new[]
                    {
                        "Minggu 1",
                        "Minggu 2",
                        "Minggu 3",
                        "Minggu 4"
                    }
            }
            };

            pnlChartUangTunai.Controls.Add(chartUang);
        }


        private void LoadMingguTerpilih()
        {
            LaporanController ctrl = new LaporanController();
            int minggu = Convert.ToInt32(comboBox1.SelectedItem);

            lblAlQuranMingguan.Text = ctrl.GetTotalDonasiMingguan("Al-Quran", minggu) + " Buah";
            lblMakananMingguan.Text = ctrl.GetTotalDonasiMingguan("Makanan/Minuman", minggu) + " Porsi";
            lblAlatSholatMingguan.Text = ctrl.GetTotalDonasiMingguan("Alat Sholat", minggu) + " Set";

            int uang = ctrl.GetTotalDonasiMingguan("Uang Tunai", minggu);

            lblUangTunaiMingguan.Text = "Rp " + uang.ToString("N0");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMingguTerpilih();
        }


        private void btnDashboard4_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }

        private void btdDaDonatur4_Click(object sender, EventArgs e)
        {
            InfoDonatur frm = new InfoDonatur();
            frm.Show();
            this.Hide();
        }

        private void btnDaDonasi4_Click(object sender, EventArgs e)
        {
            InfoDonasi frm = new InfoDonasi();
            frm.Show();
            this.Hide();
        }

        private void btnLogout4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda Telah Logout");

            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnUserAkun4_Click(object sender, EventArgs e)
        {
            UserAkun frm = new UserAkun();
            frm.Show();
            this.Hide();
        }
    }
}
