using Project_Akhir.Controllers;
using Project_Akhir.Models;
using System;
using System.Windows.Forms;

namespace Project_Akhir
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            TBpassword.UseSystemPasswordChar = true;
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            string user = TBusername.Text;
            string pass = TBpassword.Text;

            AutentikasiController auth = new AutentikasiController();

            string role = auth.Login(user, pass);

            // POLYMORPHISM
            User pengguna = null;

            if (role == "Admin")
            {
                pengguna = new Admin();

                MessageBox.Show("Login berhasil sebagai " + pengguna.GetRole());

                Dashboard dashboardAdmin = new Dashboard();
                dashboardAdmin.Show();

                this.Hide();
            }
            else if (role == "Donatur")
            {
                pengguna = new DonaturLogin();

                MessageBox.Show("Login berhasil sebagai " + pengguna.GetRole());

                FormDonasi dashboardDonatur = new FormDonasi();
                dashboardDonatur.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }

        private void linkRegister_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();

            register.Show();

            this.Hide();
        }
    }
}