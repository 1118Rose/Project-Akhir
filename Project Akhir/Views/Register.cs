using Project_Akhir.Controllers;
using Project_Akhir.Helpers;

namespace Project_Akhir
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            TBpassword.UseSystemPasswordChar = true;
            TBkonfirmasiPassword.UseSystemPasswordChar = true;
        }

        private void BTNregister_Click(object sender, EventArgs e)
        {
            string email = TBemail.Text;

            string username = TBusername.Text;

            string password = TBpassword.Text;

            string konfirmasiPassword = TBkonfirmasiPassword.Text;

            if (string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(konfirmasiPassword))
            {
                MessageBox.Show("Semua data wajib diisi!");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }

            if (password.Length < 5)
            {
                MessageBox.Show("Password minimal 5 karakter!");
                return;
            }

            if (password != konfirmasiPassword)
            {
                MessageBox.Show("Konfirmasi password tidak sesuai!");
                return;
            }


            AutentikasiController auth = new AutentikasiController();

            bool berhasil = auth.Register(email, username, password);

            if (berhasil)
            {
                MessageBox.Show("Registrasi berhasil!");

                Login lgn = new Login();

                lgn.Show();

                this.Close();
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lgn = new Login();

            lgn.Show();

            this.Close();

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