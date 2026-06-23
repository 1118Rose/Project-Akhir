using Project_Akhir.Controllers;
using System;

namespace Project_Akhir
{
    public partial class InfoDonasi : Form
    {
        public InfoDonasi()
        {
            InitializeComponent();
        }

        private void InfoDonasi_Load(object sender, EventArgs e)
        {
            InfoDonasiController ctrl = new InfoDonasiController();

            dataGridView3.DataSource = ctrl.GetDonasi();

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.GridColor = Color.White;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.BackgroundColor = Color.White;

            LoadDonasi();
        }
        private void LoadDonasi()
        {
            InfoDonasiController ctrl = new InfoDonasiController();

            dataGridView3.DataSource = ctrl.GetDonasi();

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.GridColor = Color.White;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.BackgroundColor = Color.White;
        }

        private void btnCariDonasi_Click(object sender, EventArgs e)
        {
            InfoDonasiController ctrl = new InfoDonasiController();

            dataGridView3.DataSource = ctrl.CariDonasi(txtJenisDonasi.Text);

        }

        private void btnDashboard3_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();

        }

        private void btnDaDonatur3_Click(object sender, EventArgs e)
        {
            InfoDonatur frm = new InfoDonatur();
            frm.Show();
            this.Hide();

        }

        private void btnLaporan3_Click(object sender, EventArgs e)
        {
            Laporan frm = new Laporan();
            frm.Show();
            this.Hide();
        }

        private void btnLogout3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda Telah Logout");

            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnSearchDonasi_Click(object sender, EventArgs e)
        {
            InfoDonasiController ctrl = new InfoDonasiController();

            dataGridView3.DataSource = ctrl.FilterTanggal(dateTimePicker1.Value);
        }

        private void btnUserAkun2_Click(object sender, EventArgs e)
        {
            UserAkun frm = new UserAkun();
            frm.Show();
            this.Hide();
        }

        private void btnRefresh3_Click(object sender, EventArgs e)
        {
            LoadDonasi();

            txtJenisDonasi.Clear();
            dateTimePicker1.Value = DateTime.Now;

            MessageBox.Show(
                "Data berhasil diperbarui",
                "Refresh",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
