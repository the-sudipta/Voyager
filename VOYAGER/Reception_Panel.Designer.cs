
namespace VOYAGER
{
    partial class Reception_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception_Panel));
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_message = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roundPictureBox_search = new VOYAGER.RoundPicturech();
            this.button_logout = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panelControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel_ControlBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox_search)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(334, 15);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(322, 42);
            this.label_title.TabIndex = 17;
            this.label_title.Text = "Receptionist Panel";
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
            this.panel_ControlBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 71);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_message);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_logout);
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 92);
            this.panel2.TabIndex = 31;
            // 
            // pictureBox_message
            // 
            this.pictureBox_message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_message.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_message.Image")));
            this.pictureBox_message.Location = new System.Drawing.Point(12, 28);
            this.pictureBox_message.Name = "pictureBox_message";
            this.pictureBox_message.Size = new System.Drawing.Size(48, 39);
            this.pictureBox_message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_message.TabIndex = 34;
            this.pictureBox_message.TabStop = false;
            this.pictureBox_message.Click += new System.EventHandler(this.pictureBox_message_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.roundPictureBox_search);
            this.panel3.Location = new System.Drawing.Point(378, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 39);
            this.panel3.TabIndex = 33;
            // 
            // roundPictureBox_search
            // 
            this.roundPictureBox_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundPictureBox_search.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox_search.Image")));
            this.roundPictureBox_search.Location = new System.Drawing.Point(12, 7);
            this.roundPictureBox_search.Name = "roundPictureBox_search";
            this.roundPictureBox_search.Size = new System.Drawing.Size(26, 26);
            this.roundPictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox_search.TabIndex = 32;
            this.roundPictureBox_search.TabStop = false;
            this.roundPictureBox_search.Click += new System.EventHandler(this.roundPictureBox_search_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.White;
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.Black;
            this.button_logout.Location = new System.Drawing.Point(790, 28);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(189, 39);
            this.button_logout.TabIndex = 30;
            this.button_logout.Text = "LOG OUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(69, 28);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(310, 39);
            this.textBox_search.TabIndex = 31;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 108);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1003, 487);
            this.panelControls.TabIndex = 32;
            // 
            // Reception_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1003, 687);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ControlBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reception_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reception Panel";
            this.Load += new System.EventHandler(this.Reception_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel_ControlBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundPicturech roundPictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panelControls;
        public System.Windows.Forms.Label label_title;
        public System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_message;
    }
}