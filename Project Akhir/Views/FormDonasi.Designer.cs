namespace Project_Akhir
{
    partial class FormDonasi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonasi));
            txNama = new TextBox();
            btnSubmit = new Button();
            lbNama = new Label();
            lbNoTelp = new Label();
            lbEmail = new Label();
            lbJenisDona = new Label();
            lbJumlah = new Label();
            txNoTelp = new TextBox();
            txEmail = new TextBox();
            txJumlah = new TextBox();
            comboJenisDona = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txNama
            // 
            txNama.Location = new Point(263, 118);
            txNama.Name = "txNama";
            txNama.Size = new Size(301, 27);
            txNama.TabIndex = 1;
            txNama.TextChanged += txtNama_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkGreen;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(331, 384);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(106, 30);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.BackColor = Color.Transparent;
            lbNama.Location = new Point(154, 121);
            lbNama.Name = "lbNama";
            lbNama.Size = new Size(49, 20);
            lbNama.TabIndex = 9;
            lbNama.Text = "Nama";
            // 
            // lbNoTelp
            // 
            lbNoTelp.AutoSize = true;
            lbNoTelp.BackColor = Color.Transparent;
            lbNoTelp.Location = new Point(154, 165);
            lbNoTelp.Name = "lbNoTelp";
            lbNoTelp.Size = new Size(64, 20);
            lbNoTelp.TabIndex = 10;
            lbNoTelp.Text = "No. Telp";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.Transparent;
            lbEmail.Location = new Point(154, 212);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 11;
            lbEmail.Text = "Email";
            // 
            // lbJenisDona
            // 
            lbJenisDona.AutoSize = true;
            lbJenisDona.BackColor = Color.Transparent;
            lbJenisDona.Location = new Point(154, 266);
            lbJenisDona.Name = "lbJenisDona";
            lbJenisDona.Size = new Size(90, 20);
            lbJenisDona.TabIndex = 12;
            lbJenisDona.Text = "Jenis Donasi";
            // 
            // lbJumlah
            // 
            lbJumlah.AutoSize = true;
            lbJumlah.BackColor = Color.Transparent;
            lbJumlah.Location = new Point(154, 314);
            lbJumlah.Name = "lbJumlah";
            lbJumlah.Size = new Size(55, 20);
            lbJumlah.TabIndex = 13;
            lbJumlah.Text = "Jumlah";
            lbJumlah.Click += label5_Click;
            // 
            // txNoTelp
            // 
            txNoTelp.Location = new Point(263, 162);
            txNoTelp.Name = "txNoTelp";
            txNoTelp.Size = new Size(301, 27);
            txNoTelp.TabIndex = 14;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(263, 212);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(301, 27);
            txEmail.TabIndex = 15;
            // 
            // txJumlah
            // 
            txJumlah.Location = new Point(263, 311);
            txJumlah.Name = "txJumlah";
            txJumlah.Size = new Size(301, 27);
            txJumlah.TabIndex = 17;
            // 
            // comboJenisDona
            // 
            comboJenisDona.FormattingEnabled = true;
            comboJenisDona.Items.AddRange(new object[] { "Al-Quran", "Alat Sholat", "Makanan/Minuman", "Uang Tunai" });
            comboJenisDona.Location = new Point(263, 263);
            comboJenisDona.Name = "comboJenisDona";
            comboJenisDona.Size = new Size(301, 28);
            comboJenisDona.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Noto Sans SC", 18F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(263, 20);
            label1.Name = "label1";
            label1.Size = new Size(276, 44);
            label1.TabIndex = 19;
            label1.Text = "Data Diri Donatur";
            // 
            // FormDonasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboJenisDona);
            Controls.Add(txJumlah);
            Controls.Add(txEmail);
            Controls.Add(txNoTelp);
            Controls.Add(lbJumlah);
            Controls.Add(lbJenisDona);
            Controls.Add(lbEmail);
            Controls.Add(lbNoTelp);
            Controls.Add(lbNama);
            Controls.Add(btnSubmit);
            Controls.Add(txNama);
            Name = "FormDonasi";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txNama;
        private Button btnSubmit;

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private Label lbNama;
        private Label lbNoTelp;
        private Label lbEmail;
        private Label lbJenisDona;
        private Label lbJumlah;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private TextBox txNoTelp;
        private TextBox txEmail;
        private TextBox txJumlah;
        private ComboBox comboJenisDona;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Label label1;
    }
}
