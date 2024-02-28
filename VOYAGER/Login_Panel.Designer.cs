
namespace VOYAGER
{
    partial class Login_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Panel));
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_continue = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.panel_ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ControlBox
            // 
            this.panel_ControlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ControlBox.Controls.Add(this.pictureBox_maximize);
            this.panel_ControlBox.Controls.Add(this.pictureBox_minimize);
            this.panel_ControlBox.Controls.Add(this.pictureBox_close);
            this.panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBox.Name = "panel_ControlBox";
            this.panel_ControlBox.Size = new System.Drawing.Size(1003, 37);
            this.panel_ControlBox.TabIndex = 0;
            // 
            // pictureBox_maximize
            // 
            this.pictureBox_maximize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox_maximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_maximize.Image")));
            this.pictureBox_maximize.Location = new System.Drawing.Point(928, 3);
            this.pictureBox_maximize.Name = "pictureBox_maximize";
            this.pictureBox_maximize.Size = new System.Drawing.Size(28, 29);
            this.pictureBox_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_maximize.TabIndex = 3;
            this.pictureBox_maximize.TabStop = false;
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimize.Image")));
            this.pictureBox_minimize.Location = new System.Drawing.Point(894, 3);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Size = new System.Drawing.Size(28, 29);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_minimize.TabIndex = 2;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(962, 3);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(28, 29);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 1;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(426, 173);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(142, 55);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "Login";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(344, 308);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(52, 22);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "EMAIL";
            // 
            // textBox_mail
            // 
            this.textBox_mail.BackColor = System.Drawing.Color.Black;
            this.textBox_mail.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mail.ForeColor = System.Drawing.Color.White;
            this.textBox_mail.Location = new System.Drawing.Point(348, 333);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(313, 41);
            this.textBox_mail.TabIndex = 4;
            this.textBox_mail.TextChanged += new System.EventHandler(this.textBox_mail_TextChanged);
            this.textBox_mail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_mail_KeyDown);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.Black;
            this.textBox_password.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(348, 416);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(313, 41);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "PASSWORD";
            // 
            // label_continue
            // 
            this.label_continue.AutoSize = true;
            this.label_continue.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_continue.Location = new System.Drawing.Point(416, 242);
            this.label_continue.Name = "label_continue";
            this.label_continue.Size = new System.Drawing.Size(165, 20);
            this.label_continue.TabIndex = 7;
            this.label_continue.Text = "S i g n   i n   t o   c o n t i n u e";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.White;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(396, 496);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(218, 39);
            this.button_login.TabIndex = 8;
            this.button_login.Text = "log in";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Login_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1003, 638);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_continue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.panel_ControlBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Panel";
            this.Load += new System.EventHandler(this.Login_Panel_Load);
            this.panel_ControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_continue;
        private System.Windows.Forms.Button button_login;
    }
}

