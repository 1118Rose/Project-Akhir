using Project_Akhir.Controllers;
using System;

namespace Project_Akhir
{
    public partial class UserAkun : Form
    {
        public UserAkun()
        {
            InitializeComponent();
        }
        private void LoadUser()
        {
            UserAkunController ctrl = new UserAkunController();

            dataGridView3.DataSource = ctrl.GetUser();

            dataGridView3.Columns["id_account"].Visible = false;
        }
        private void UserAkun_Load(object sender, EventArgs e)
        {
            LoadUser();

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCariNama2_Click(object sender, EventArgs e)
        {
            UserAkunController ctlr = new UserAkunController();
            dataGridView3.DataSource = ctlr.CariUser(txtNamaDonatur2.Text);
        }

        private void btnRefresh4_Click(object sender, EventArgs e)
        {
            txtNamaDonatur2.Clear();
            LoadUser();
            txtNamaDonatur2.Focus();
        }

        private int idAccount;

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idAccount = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["id_account"].Value);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                    "Yakin ingin menghapus akun ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                UserAkunController ctrl = new UserAkunController();

                if (ctrl.DeleteUser(idAccount))
                {
                    MessageBox.Show("Data berhasil dihapus");

                    LoadUser();
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditUserAkun frm = new EditUserAkun
                (idAccount,
        dataGridView3.CurrentRow.Cells["Nama"].Value.ToString(),
        dataGridView3.CurrentRow.Cells["Email"].Value.ToString(),
        dataGridView3.CurrentRow.Cells["No Telp"].Value.ToString(),
        dataGridView3.CurrentRow.Cells["Role"].Value.ToString());

            frm.ShowDialog();

            LoadUser();
        }

        private void btnLogout5_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
    
