using Project_Akhir.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Akhir
{
    public partial class EditUserAkun : Form
    {
        private int idAccount;

        public EditUserAkun(
            int id,
            string nama,
            string email,
            string noTelp,
            string role)
        {
            InitializeComponent();

            idAccount = id;

            cmbEdit.Items.Add("Admin");
            cmbEdit.Items.Add("Donatur");

            txtNamaEdit.Text = nama;
            txtEmailEdit.Text = email;
            txtNoTelpEdit.Text = noTelp;
            cmbEdit.SelectedItem = role;
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            UserAkunController ctrl = new UserAkunController();

            bool berhasil = ctrl.UpdateUser(
                idAccount,
                txtNamaEdit.Text,
                txtEmailEdit.Text,
                txtNoTelpEdit.Text,
                cmbEdit.Text);

            if (berhasil)
            {
                MessageBox.Show(
                    "Data berhasil diperbarui!",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }


}
