namespace Project_Akhir
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtUsername = new Label();
            txtPassword = new Label();
            TBusername = new TextBox();
            TBpassword = new TextBox();
            BTNlogin = new Button();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSeaGreen;
            label1.Location = new Point(274, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 0;
            label1.Text = "SIGN IN";
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.BackColor = Color.Transparent;
            txtUsername.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(108, 132);
            txtUsername.Margin = new Padding(2, 0, 2, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(81, 18);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(108, 193);
            txtPassword.Margin = new Padding(2, 0, 2, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(79, 18);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password:";
            // 
            // TBusername
            // 
            TBusername.BackColor = Color.White;
            TBusername.Location = new Point(211, 128);
            TBusername.Margin = new Padding(2);
            TBusername.Name = "TBusername";
            TBusername.Size = new Size(284, 27);
            TBusername.TabIndex = 3;
            // 
            // TBpassword
            // 
            TBpassword.BackColor = Color.White;
            TBpassword.Location = new Point(211, 189);
            TBpassword.Margin = new Padding(2);
            TBpassword.Name = "TBpassword";
            TBpassword.Size = new Size(284, 27);
            TBpassword.TabIndex = 4;
            TBpassword.UseSystemPasswordChar = true;
            // 
            // BTNlogin
            // 
            BTNlogin.BackColor = Color.DarkGreen;
            BTNlogin.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNlogin.ForeColor = Color.Transparent;
            BTNlogin.Location = new Point(291, 254);
            BTNlogin.Margin = new Padding(2);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(90, 32);
            BTNlogin.TabIndex = 5;
            BTNlogin.Text = "LOGIN";
            BTNlogin.UseVisualStyleBackColor = false;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(211, 306);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 7;
            label3.Text = "Belum Punya Akun?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Noto Sans SC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(174, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(331, 44);
            label2.TabIndex = 9;
            label2.Text = "Welcome To SIMANEJ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(360, 304);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkRegister_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 360);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(BTNlogin);
            Controls.Add(TBpassword);
            Controls.Add(TBusername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtUsername;
        private Label txtPassword;
        private TextBox TBusername;
        private TextBox TBpassword;
        private Button BTNlogin;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}
