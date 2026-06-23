namespace Project_Akhir
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            btnUserAkun = new Button();
            btnLap1 = new Button();
            pictureBox1 = new PictureBox();
            btnLogout1 = new Button();
            btnDaDonasi1 = new Button();
            btdDaDonatur1 = new Button();
            btnDashboard = new Button();
            pnlTotalDonatur = new Panel();
            label1 = new Label();
            lblTotalDonatur = new Label();
            pictureBox2 = new PictureBox();
            btnRefresh = new Button();
            pnlTotalQuran = new Panel();
            label9 = new Label();
            label4 = new Label();
            lblAlQuran = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label6 = new Label();
            LBLJam = new System.Windows.Forms.Timer(components);
            pnlTotalMakanan = new Panel();
            label10 = new Label();
            label5 = new Label();
            lblMakanan = new Label();
            pictureBox4 = new PictureBox();
            pnlTotalUang = new Panel();
            label12 = new Label();
            label8 = new Label();
            lblUangTunai = new Label();
            pictureBox6 = new PictureBox();
            pnlTotalASholat = new Panel();
            label11 = new Label();
            label7 = new Label();
            lblAlatSholatt = new Label();
            pictureBox5 = new PictureBox();
            dgvDonatur = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTotalDonatur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlTotalQuran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlTotalMakanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlTotalUang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlTotalASholat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonatur).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnUserAkun);
            panel1.Controls.Add(btnLap1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogout1);
            panel1.Controls.Add(btnDaDonasi1);
            panel1.Controls.Add(btdDaDonatur1);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 580);
            panel1.TabIndex = 0;
            // 
            // btnUserAkun
            // 
            btnUserAkun.AutoEllipsis = true;
            btnUserAkun.BackColor = Color.Transparent;
            btnUserAkun.FlatStyle = FlatStyle.Flat;
            btnUserAkun.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserAkun.ForeColor = Color.White;
            btnUserAkun.Image = (Image)resources.GetObject("btnUserAkun.Image");
            btnUserAkun.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserAkun.Location = new Point(22, 416);
            btnUserAkun.Name = "btnUserAkun";
            btnUserAkun.Size = new Size(150, 36);
            btnUserAkun.TabIndex = 13;
            btnUserAkun.Text = "    User Akun";
            btnUserAkun.UseVisualStyleBackColor = false;
            btnUserAkun.Click += btnUserAkun_Click;
            // 
            // btnLap1
            // 
            btnLap1.BackColor = Color.Transparent;
            btnLap1.FlatStyle = FlatStyle.Flat;
            btnLap1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLap1.ForeColor = Color.White;
            btnLap1.Image = Properties.Resources.icon_park_outline__table_report;
            btnLap1.ImageAlign = ContentAlignment.MiddleLeft;
            btnLap1.Location = new Point(21, 363);
            btnLap1.Name = "btnLap1";
            btnLap1.Size = new Size(150, 36);
            btnLap1.TabIndex = 11;
            btnLap1.Text = "    Laporan";
            btnLap1.UseVisualStyleBackColor = false;
            btnLap1.Click += btnLap1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Simanej;
            pictureBox1.Location = new Point(22, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnLogout1
            // 
            btnLogout1.BackColor = Color.Transparent;
            btnLogout1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout1.ForeColor = Color.Black;
            btnLogout1.Image = Properties.Resources.heroicons_solid__logout1;
            btnLogout1.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout1.Location = new Point(22, 535);
            btnLogout1.Name = "btnLogout1";
            btnLogout1.Size = new Size(150, 36);
            btnLogout1.TabIndex = 9;
            btnLogout1.Text = "Logout";
            btnLogout1.UseVisualStyleBackColor = false;
            btnLogout1.Click += btnLogout1_Click;
            // 
            // btnDaDonasi1
            // 
            btnDaDonasi1.BackColor = Color.Transparent;
            btnDaDonasi1.FlatStyle = FlatStyle.Flat;
            btnDaDonasi1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaDonasi1.ForeColor = Color.White;
            btnDaDonasi1.Image = Properties.Resources.gg__box__2_;
            btnDaDonasi1.ImageAlign = ContentAlignment.MiddleLeft;
            btnDaDonasi1.Location = new Point(22, 307);
            btnDaDonasi1.Name = "btnDaDonasi1";
            btnDaDonasi1.Size = new Size(150, 36);
            btnDaDonasi1.TabIndex = 6;
            btnDaDonasi1.Text = "    Data Donasi";
            btnDaDonasi1.UseVisualStyleBackColor = false;
            btnDaDonasi1.Click += btnDaDonasi1_Click;
            // 
            // btdDaDonatur1
            // 
            btdDaDonatur1.BackColor = Color.Transparent;
            btdDaDonatur1.FlatStyle = FlatStyle.Flat;
            btdDaDonatur1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btdDaDonatur1.ForeColor = Color.White;
            btdDaDonatur1.Image = Properties.Resources.wordpress__people__1_;
            btdDaDonatur1.ImageAlign = ContentAlignment.MiddleLeft;
            btdDaDonatur1.Location = new Point(22, 253);
            btdDaDonatur1.Name = "btdDaDonatur1";
            btdDaDonatur1.Size = new Size(150, 36);
            btdDaDonatur1.TabIndex = 5;
            btdDaDonatur1.Text = "      Data Donatur";
            btdDaDonatur1.UseVisualStyleBackColor = false;
            btdDaDonatur1.Click += btdDaDonatur1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(192, 255, 192);
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.lsicon__home_outline__2_;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(22, 198);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 36);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = " Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlTotalDonatur
            // 
            pnlTotalDonatur.BackColor = Color.MistyRose;
            pnlTotalDonatur.BackgroundImage = (Image)resources.GetObject("pnlTotalDonatur.BackgroundImage");
            pnlTotalDonatur.Controls.Add(label1);
            pnlTotalDonatur.Controls.Add(lblTotalDonatur);
            pnlTotalDonatur.Controls.Add(pictureBox2);
            pnlTotalDonatur.Location = new Point(207, 95);
            pnlTotalDonatur.Name = "pnlTotalDonatur";
            pnlTotalDonatur.Size = new Size(263, 112);
            pnlTotalDonatur.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(4, 54);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 3;
            label1.Text = "Total Donatur";
            // 
            // lblTotalDonatur
            // 
            lblTotalDonatur.AutoSize = true;
            lblTotalDonatur.BackColor = Color.Transparent;
            lblTotalDonatur.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDonatur.Location = new Point(5, 25);
            lblTotalDonatur.Name = "lblTotalDonatur";
            lblTotalDonatur.Size = new Size(172, 31);
            lblTotalDonatur.TabIndex = 2;
            lblTotalDonatur.Text = "lblTotalDonatur";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(208, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Image = Properties.Resources.solar__refresh_broken;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(847, 344);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(155, 36);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlTotalQuran
            // 
            pnlTotalQuran.BackColor = Color.MistyRose;
            pnlTotalQuran.Controls.Add(label9);
            pnlTotalQuran.Controls.Add(label4);
            pnlTotalQuran.Controls.Add(lblAlQuran);
            pnlTotalQuran.Controls.Add(pictureBox3);
            pnlTotalQuran.Cursor = Cursors.Cross;
            pnlTotalQuran.Location = new Point(486, 95);
            pnlTotalQuran.Name = "pnlTotalQuran";
            pnlTotalQuran.Size = new Size(245, 112);
            pnlTotalQuran.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 82);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 4;
            label9.Text = "Eksemplar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 4;
            label4.Text = "Donasi Al-Quran";
            // 
            // lblAlQuran
            // 
            lblAlQuran.AutoSize = true;
            lblAlQuran.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlQuran.Location = new Point(6, 25);
            lblAlQuran.Name = "lblAlQuran";
            lblAlQuran.Size = new Size(124, 31);
            lblAlQuran.TabIndex = 3;
            lblAlQuran.Text = "lblAlQuran";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(192, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 14;
            label2.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(207, 20);
            label6.Name = "label6";
            label6.Size = new Size(263, 29);
            label6.TabIndex = 17;
            label6.Text = "Selamat Datang, Admin";
            // 
            // LBLJam
            // 
            LBLJam.Enabled = true;
            // 
            // pnlTotalMakanan
            // 
            pnlTotalMakanan.BackColor = Color.MistyRose;
            pnlTotalMakanan.BackgroundImage = (Image)resources.GetObject("pnlTotalMakanan.BackgroundImage");
            pnlTotalMakanan.Controls.Add(label10);
            pnlTotalMakanan.Controls.Add(label5);
            pnlTotalMakanan.Controls.Add(lblMakanan);
            pnlTotalMakanan.Controls.Add(pictureBox4);
            pnlTotalMakanan.Location = new Point(750, 95);
            pnlTotalMakanan.Name = "pnlTotalMakanan";
            pnlTotalMakanan.Size = new Size(255, 112);
            pnlTotalMakanan.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(3, 82);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 5;
            label10.Text = "Paket Tersalur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(3, 54);
            label5.Name = "label5";
            label5.Size = new Size(170, 28);
            label5.TabIndex = 4;
            label5.Text = "Donasi Makanan";
            // 
            // lblMakanan
            // 
            lblMakanan.AutoSize = true;
            lblMakanan.BackColor = Color.Transparent;
            lblMakanan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMakanan.Location = new Point(3, 25);
            lblMakanan.Name = "lblMakanan";
            lblMakanan.Size = new Size(281, 31);
            lblMakanan.TabIndex = 3;
            lblMakanan.Text = "lblTotalMakananMinuman";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(199, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pnlTotalUang
            // 
            pnlTotalUang.BackColor = Color.MistyRose;
            pnlTotalUang.BackgroundImage = (Image)resources.GetObject("pnlTotalUang.BackgroundImage");
            pnlTotalUang.Controls.Add(label12);
            pnlTotalUang.Controls.Add(label8);
            pnlTotalUang.Controls.Add(lblUangTunai);
            pnlTotalUang.Controls.Add(pictureBox6);
            pnlTotalUang.Location = new Point(454, 231);
            pnlTotalUang.Name = "pnlTotalUang";
            pnlTotalUang.Size = new Size(251, 112);
            pnlTotalUang.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(3, 84);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 22;
            label12.Text = "Total Terkumpul";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(3, 61);
            label8.Name = "label8";
            label8.Size = new Size(159, 23);
            label8.TabIndex = 22;
            label8.Text = "Donasi Uang Tunai";
            // 
            // lblUangTunai
            // 
            lblUangTunai.AutoSize = true;
            lblUangTunai.BackColor = Color.Transparent;
            lblUangTunai.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUangTunai.Location = new Point(3, 22);
            lblUangTunai.Name = "lblUangTunai";
            lblUangTunai.Size = new Size(200, 31);
            lblUangTunai.TabIndex = 6;
            lblUangTunai.Text = "lblTotalUangTunai";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(200, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 41);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // pnlTotalASholat
            // 
            pnlTotalASholat.BackColor = Color.MistyRose;
            pnlTotalASholat.Controls.Add(label11);
            pnlTotalASholat.Controls.Add(label7);
            pnlTotalASholat.Controls.Add(lblAlatSholatt);
            pnlTotalASholat.Controls.Add(pictureBox5);
            pnlTotalASholat.Location = new Point(207, 231);
            pnlTotalASholat.Name = "pnlTotalASholat";
            pnlTotalASholat.Size = new Size(225, 112);
            pnlTotalASholat.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 84);
            label11.Name = "label11";
            label11.Size = new Size(89, 20);
            label11.TabIndex = 20;
            label11.Text = "Item Donasi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(5, 59);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 21;
            label7.Text = "Alat Sholat";
            // 
            // lblAlatSholatt
            // 
            lblAlatSholatt.AutoSize = true;
            lblAlatSholatt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlatSholatt.Location = new Point(4, 22);
            lblAlatSholatt.Name = "lblAlatSholatt";
            lblAlatSholatt.Size = new Size(119, 31);
            lblAlatSholatt.TabIndex = 20;
            lblAlatSholatt.Text = "lblASholat";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(171, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // dgvDonatur
            // 
            dgvDonatur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonatur.Location = new Point(207, 386);
            dgvDonatur.Name = "dgvDonatur";
            dgvDonatur.ReadOnly = true;
            dgvDonatur.RowHeadersWidth = 51;
            dgvDonatur.Size = new Size(795, 182);
            dgvDonatur.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(207, 363);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 1;
            label3.Text = "Donatur Terbaru";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1017, 580);
            Controls.Add(label3);
            Controls.Add(dgvDonatur);
            Controls.Add(pnlTotalASholat);
            Controls.Add(pnlTotalUang);
            Controls.Add(pnlTotalMakanan);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(pnlTotalQuran);
            Controls.Add(pnlTotalDonatur);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Form1";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTotalDonatur.ResumeLayout(false);
            pnlTotalDonatur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlTotalQuran.ResumeLayout(false);
            pnlTotalQuran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlTotalMakanan.ResumeLayout(false);
            pnlTotalMakanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlTotalUang.ResumeLayout(false);
            pnlTotalUang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlTotalASholat.ResumeLayout(false);
            pnlTotalASholat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonatur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnLogout1;
        private Button btnDaDonasi1;
        private Button btdDaDonatur1;
        private Button btnDashboard;
        private Panel pnlTotalDonatur;
        private Button btnRefresh;
        private Panel pnlTotalQuran;
        private Label label2;
        private Label label6;
        private System.Windows.Forms.Timer LBLJam;
        private PictureBox pictureBox1;
        private Button btnLap1;
        private Panel pnlTotalMakanan;
        private Panel pnlTotalUang;
        private Panel pnlTotalASholat;
        private DataGridView dgvDonatur;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lblTotalDonatur;
        private Label lblAlQuran;
        private Label lblMakanan;
        private Label lblUangTunai;
        private Label lblAlatSholat;
        private Label lblAlatSholatt;
        private Label label1;
        private Label label9;
        private Label label4;
        private Label label10;
        private Label label5;
        private Label label12;
        private Label label8;
        private Label label11;
        private Label label7;
        private Button btnUserAkun;
    }
}
