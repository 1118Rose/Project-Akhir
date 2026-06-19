namespace Project_Akhir
{
    partial class InfoDonasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDonasi));
            panel2 = new Panel();
            btnLaporan3 = new Button();
            pictureBox1 = new PictureBox();
            btnLogout3 = new Button();
            btnDaSi = new Button();
            btnDaDonatur3 = new Button();
            btnDashboard3 = new Button();
            label6 = new Label();
            lblJenisDonasi = new Label();
            btnCariDonasi = new Button();
            txtJenisDonasi = new TextBox();
            dataGridView3 = new DataGridView();
            button4 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button9 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btnLaporan3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnLogout3);
            panel2.Controls.Add(btnDaSi);
            panel2.Controls.Add(btnDaDonatur3);
            panel2.Controls.Add(btnDashboard3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 581);
            panel2.TabIndex = 11;
            // 
            // btnLaporan3
            // 
            btnLaporan3.BackColor = Color.Transparent;
            btnLaporan3.FlatStyle = FlatStyle.Flat;
            btnLaporan3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaporan3.Image = Properties.Resources.icon_park_outline__table_report;
            btnLaporan3.ImageAlign = ContentAlignment.MiddleLeft;
            btnLaporan3.Location = new Point(21, 363);
            btnLaporan3.Name = "btnLaporan3";
            btnLaporan3.Size = new Size(150, 36);
            btnLaporan3.TabIndex = 11;
            btnLaporan3.Text = "    Laporan";
            btnLaporan3.UseVisualStyleBackColor = false;
            btnLaporan3.Click += btnLaporan3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Simanej2;
            pictureBox1.Location = new Point(22, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnLogout3
            // 
            btnLogout3.BackColor = Color.Transparent;
            btnLogout3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout3.Image = Properties.Resources.heroicons_solid__logout1;
            btnLogout3.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout3.Location = new Point(22, 535);
            btnLogout3.Name = "btnLogout3";
            btnLogout3.Size = new Size(150, 36);
            btnLogout3.TabIndex = 9;
            btnLogout3.Text = "Logout";
            btnLogout3.UseVisualStyleBackColor = false;
            btnLogout3.Click += this.btnLogout3_Click;
            // 
            // btnDaSi
            // 
            btnDaSi.BackColor = Color.FromArgb(192, 255, 192);
            btnDaSi.BackgroundImage = (Image)resources.GetObject("btnDaSi.BackgroundImage");
            btnDaSi.FlatStyle = FlatStyle.Flat;
            btnDaSi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaSi.Image = Properties.Resources.gg__box__2_;
            btnDaSi.ImageAlign = ContentAlignment.MiddleLeft;
            btnDaSi.Location = new Point(22, 307);
            btnDaSi.Name = "btnDaSi";
            btnDaSi.Size = new Size(150, 36);
            btnDaSi.TabIndex = 6;
            btnDaSi.Text = "    Data Donasi";
            btnDaSi.UseVisualStyleBackColor = false;
            // 
            // btnDaDonatur3
            // 
            btnDaDonatur3.BackColor = Color.Transparent;
            btnDaDonatur3.FlatStyle = FlatStyle.Flat;
            btnDaDonatur3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaDonatur3.Image = Properties.Resources.wordpress__people__1_;
            btnDaDonatur3.ImageAlign = ContentAlignment.MiddleLeft;
            btnDaDonatur3.Location = new Point(22, 253);
            btnDaDonatur3.Name = "btnDaDonatur3";
            btnDaDonatur3.Size = new Size(150, 36);
            btnDaDonatur3.TabIndex = 5;
            btnDaDonatur3.Text = "      Data Donatur";
            btnDaDonatur3.UseVisualStyleBackColor = false;
            btnDaDonatur3.Click += btnDaDonatur3_Click;
            // 
            // btnDashboard3
            // 
            btnDashboard3.BackColor = Color.Transparent;
            btnDashboard3.FlatStyle = FlatStyle.Flat;
            btnDashboard3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard3.Image = Properties.Resources.lsicon__home_outline__2_;
            btnDashboard3.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard3.Location = new Point(22, 198);
            btnDashboard3.Name = "btnDashboard3";
            btnDashboard3.Size = new Size(150, 36);
            btnDashboard3.TabIndex = 4;
            btnDashboard3.Text = " Dashboard";
            btnDashboard3.UseVisualStyleBackColor = false;
            btnDashboard3.Click += btnDashboard3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(214, 35);
            label6.Name = "label6";
            label6.Size = new Size(263, 29);
            label6.TabIndex = 18;
            label6.Text = "Selamat Datang, Admin";
            // 
            // lblJenisDonasi
            // 
            lblJenisDonasi.AutoSize = true;
            lblJenisDonasi.BackColor = Color.Transparent;
            lblJenisDonasi.Location = new Point(211, 140);
            lblJenisDonasi.Name = "lblJenisDonasi";
            lblJenisDonasi.Size = new Size(90, 20);
            lblJenisDonasi.TabIndex = 23;
            lblJenisDonasi.Text = "Jenis Donasi";
            // 
            // btnCariDonasi
            // 
            btnCariDonasi.Location = new Point(384, 161);
            btnCariDonasi.Name = "btnCariDonasi";
            btnCariDonasi.Size = new Size(75, 29);
            btnCariDonasi.TabIndex = 22;
            btnCariDonasi.Text = "Search";
            btnCariDonasi.UseVisualStyleBackColor = true;
            btnCariDonasi.Click += btnCariDonasi_Click;
            // 
            // txtJenisDonasi
            // 
            txtJenisDonasi.Location = new Point(211, 163);
            txtJenisDonasi.Name = "txtJenisDonasi";
            txtJenisDonasi.Size = new Size(167, 27);
            txtJenisDonasi.TabIndex = 21;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(214, 217);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(816, 310);
            dataGridView3.TabIndex = 24;
            // 
            // button4
            // 
            button4.Location = new Point(949, 163);
            button4.Name = "button4";
            button4.Size = new Size(75, 29);
            button4.TabIndex = 30;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(693, 142);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 29;
            label2.Text = "Tanggal";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(693, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Image = Properties.Resources.solar__refresh_broken;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(211, 533);
            button9.Name = "button9";
            button9.Size = new Size(155, 36);
            button9.TabIndex = 31;
            button9.Text = "Refresh Data";
            button9.UseVisualStyleBackColor = false;
            // 
            // InfoDonasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1039, 581);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView3);
            Controls.Add(lblJenisDonasi);
            Controls.Add(btnCariDonasi);
            Controls.Add(txtJenisDonasi);
            Controls.Add(label6);
            Controls.Add(panel2);
            Name = "InfoDonasi";
            Text = "Form3";
            Load += InfoDonasi_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnLaporan3;
        private PictureBox pictureBox1;
        private Button btnLogout3;
        private Button btnDaSi;
        private Button btnDaDonatur3;
        private Button btnDashboard3;
        private Label label6;
        private Label lblJenisDonasi;
        private Button btnCariDonasi;
        private TextBox txtJenisDonasi;
        private DataGridView dataGridView3;
        private Button button4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button9;
    }
}