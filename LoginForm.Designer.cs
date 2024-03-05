namespace EcommerceAdmin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            login = new Button();
            lbExit = new Label();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Playfair Display SemiBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 154);
            label1.Name = "label1";
            label1.Size = new Size(97, 43);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(32, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(32, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 1);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 289);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // login
            // 
            login.BackColor = Color.Black;
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(32, 360);
            login.Name = "login";
            login.Size = new Size(278, 52);
            login.TabIndex = 6;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // lbExit
            // 
            lbExit.AutoSize = true;
            lbExit.Cursor = Cursors.Hand;
            lbExit.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbExit.Location = new Point(150, 438);
            lbExit.Name = "lbExit";
            lbExit.Size = new Size(37, 20);
            lbExit.TabIndex = 7;
            lbExit.Text = "Exit";
            lbExit.Click += lbExit_Click;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(63, 220);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(243, 19);
            txtPhone.TabIndex = 8;
            txtPhone.Text = "Type your phone number";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(63, 289);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '.';
            txtPassword.Size = new Size(243, 19);
            txtPassword.TabIndex = 9;
            txtPassword.Text = "Type your password";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LoginForm
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(349, 484);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(lbExit);
            Controls.Add(login);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button login;
        private Label lbExit;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private ContextMenuStrip contextMenuStrip1;
    }
}
