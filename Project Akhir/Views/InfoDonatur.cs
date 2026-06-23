using Project_Akhir.Controllers;
using System;

namespace Project_Akhir
{
    public partial class InfoDonatur : Form
    {
        public InfoDonatur()
        {
            InitializeComponent();
        }

        private void LoadDonatur()
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
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView2.GridColor = Color.White;
        }
        private void InfoDonatur_Load(object sender, EventArgs e)
        {
            LoadDonatur();
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

        private void btnSearchDonatur_Click(object sender, EventArgs e)
        {
            InfoDonaturController ctrl = new InfoDonaturController();

            dataGridView2.DataSource = ctrl.FilterTanggal(dateTimePicker1.Value);
        }

        private void btnUserAkun3_Click(object sender, EventArgs e)
        {
            UserAkun frm = new UserAkun();
            frm.Show();
            this.Hide();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            LoadDonatur();

            txtNamaDonatur.Clear();
            dateTimePicker1.Value = DateTime.Now;

            MessageBox.Show(
                "Data berhasil diperbarui",
                "Refresh",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

}
