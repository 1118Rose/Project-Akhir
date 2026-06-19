using Npgsql;
using Project_Akhir.Controllers;
using Project_Akhir.Database;
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
    public partial class InfoDonatur : Form
    {
        public InfoDonatur()
        {
            InitializeComponent();
        }

        private void InfoDonatur_Load(object sender, EventArgs e)
        {
            InfoDonaturController ctrl = new InfoDonaturController();

            dataGridView2.DataSource = ctrl.GetDonatur();

            // Styling DataGridView
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView2.GridColor = Color.White;
        }
        private void txtNamaDonatur_TextChanged(object sender, EventArgs e)
        {
            InfoDonaturController ctrl = new InfoDonaturController();

            if (string.IsNullOrWhiteSpace(txtNamaDonatur.Text))
            {
                dataGridView2.DataSource = ctrl.GetDonatur();
            }
            else
            {
                dataGridView2.DataSource = ctrl.CariDonatur(txtNamaDonatur.Text);
            }
        }

        private void btnCariNamaDonatur_Click(object sender, EventArgs e)
        {
            InfoDonaturController ctrl = new InfoDonaturController();

            dataGridView2.DataSource = ctrl.CariDonatur(txtNamaDonatur.Text);
        }
        private void btnDashboard2_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }

        private void btnDaDonasi3_Click(object sender, EventArgs e)
        {
            InfoDonasi frm = new InfoDonasi();
            frm.Show();
            this.Hide();
        }

        private void btnLaporan2_Click(object sender, EventArgs e)
        {
            Laporan frm = new Laporan();
            frm.Show();
            this.Hide();
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda Telah Logout");

            Login frm = new Login();
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
