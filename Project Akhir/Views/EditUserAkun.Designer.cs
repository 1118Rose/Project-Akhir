namespace Project_Akhir
{
    partial class EditUserAkun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserAkun));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNamaEdit = new TextBox();
            txtEmailEdit = new TextBox();
            txtNoTelpEdit = new TextBox();
            cmbEdit = new ComboBox();
            btnSubmitEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 0;
            label1.Text = "Edit User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 83);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 131);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 186);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "No.Telp:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 239);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 4;
            label5.Text = "Role:";
            // 
            // txtNamaEdit
            // 
            txtNamaEdit.Location = new Point(147, 80);
            txtNamaEdit.Name = "txtNamaEdit";
            txtNamaEdit.Size = new Size(225, 27);
            txtNamaEdit.TabIndex = 5;
            // 
            // txtEmailEdit
            // 
            txtEmailEdit.Location = new Point(147, 131);
            txtEmailEdit.Name = "txtEmailEdit";
            txtEmailEdit.Size = new Size(225, 27);
            txtEmailEdit.TabIndex = 6;
            // 
            // txtNoTelpEdit
            // 
            txtNoTelpEdit.Location = new Point(147, 183);
            txtNoTelpEdit.Name = "txtNoTelpEdit";
            txtNoTelpEdit.Size = new Size(225, 27);
            txtNoTelpEdit.TabIndex = 7;
            // 
            // cmbEdit
            // 
            cmbEdit.FormattingEnabled = true;
            cmbEdit.Items.AddRange(new object[] { "Admin", "Donatur" });
            cmbEdit.Location = new Point(147, 231);
            cmbEdit.Name = "cmbEdit";
            cmbEdit.Size = new Size(225, 28);
            cmbEdit.TabIndex = 8;
            // 
            // btnSubmitEdit
            // 
            btnSubmitEdit.Location = new Point(216, 293);
            btnSubmitEdit.Name = "btnSubmitEdit";
            btnSubmitEdit.Size = new Size(89, 26);
            btnSubmitEdit.TabIndex = 9;
            btnSubmitEdit.Text = "Submit";
            btnSubmitEdit.UseVisualStyleBackColor = true;
            btnSubmitEdit.Click += btnSubmitEdit_Click;
            // 
            // EditUserAkun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(552, 331);
            Controls.Add(btnSubmitEdit);
            Controls.Add(cmbEdit);
            Controls.Add(txtNoTelpEdit);
            Controls.Add(txtEmailEdit);
            Controls.Add(txtNamaEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUserAkun";
            Text = "EditUserAkun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNamaEdit;
        private TextBox txtEmailEdit;
        private TextBox txtNoTelpEdit;
        private ComboBox cmbEdit;
        private Button btnSubmitEdit;
    }
}