using Project_Akhir.Controllers;
using System;
using System.Windows.Forms;
using Project_Akhir.Helpers;

namespace Project_Akhir
{

    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DashboardController ctrl = new DashboardController();
            lblTotalDonatur.Text = ctrl.GetTotalDonatur();
            lblAlQuran.Text = ctrl.GetTotalAlQuran();
            lblMakanan.Text = ctrl.GetTotalMakanan();
            lblAlatSholatt.Text = ctrl.GetTotalAlatSholat();
            lblUangTunai.Text = ctrl.GetTotalUangTunai();

            dgvDonatur.DataSource = ctrl.GetDonasiTerbaru();

            UIHelper.RoundPanel(pnlTotalDonatur, 15);
            UIHelper.RoundPanel(pnlTotalQuran, 15);
            UIHelper.RoundPanel(pnlTotalMakanan, 15);
            UIHelper.RoundPanel(pnlTotalASholat, 15);
            UIHelper.RoundPanel(pnlTotalUang, 15);

            dgvDonatur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btdDaDonatur1_Click(object sender, EventArgs e)
        {
            InfoDonatur frm = new InfoDonatur();

            frm.Show();

            this.Hide();
        }
        private void btnDaDonasi1_Click(object sender, EventArgs e)
        {
            InfoDonasi frm = new InfoDonasi();

            frm.Show();

            this.Hide();
        }
        private void btnLap1_Click(object sender, EventArgs e)
        {
            Laporan frm = new Laporan();

            frm.Show();

            this.Hide();
        }

        private void btnLogout1_Click(object sender, EventArgs e)
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
