
namespace VOYAGER
{
    partial class Admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_panel));
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label_panelName = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.roundPictureBox_search = new VOYAGER.RoundPicturech();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox_message = new System.Windows.Forms.PictureBox();
            this.panel_ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox_search)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).BeginInit();
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
            this.panel_ControlBox.TabIndex = 1;
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
            // panel9
            // 
            this.panel9.Controls.Add(this.label_panelName);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 37);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1003, 100);
            this.panel9.TabIndex = 32;
            // 
            // label_panelName
            // 
            this.label_panelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_panelName.AutoSize = true;
            this.label_panelName.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_panelName.Location = new System.Drawing.Point(378, 31);
            this.label_panelName.Name = "label_panelName";
            this.label_panelName.Size = new System.Drawing.Size(226, 42);
            this.label_panelName.TabIndex = 5;
            this.label_panelName.Text = "Admin Panel";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pictureBox_message);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.textBox_search);
            this.panel10.Controls.Add(this.button_logout);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 587);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1003, 100);
            this.panel10.TabIndex = 33;
            // 
            // roundPictureBox_search
            // 
            this.roundPictureBox_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundPictureBox_search.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox_search.Image")));
            this.roundPictureBox_search.Location = new System.Drawing.Point(11, 7);
            this.roundPictureBox_search.Name = "roundPictureBox_search";
            this.roundPictureBox_search.Size = new System.Drawing.Size(26, 26);
            this.roundPictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox_search.TabIndex = 33;
            this.roundPictureBox_search.TabStop = false;
            this.roundPictureBox_search.Click += new System.EventHandler(this.roundPictureBox_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(62, 37);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(309, 39);
            this.textBox_search.TabIndex = 32;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.White;
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.Black;
            this.button_logout.Location = new System.Drawing.Point(775, 37);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(189, 39);
            this.button_logout.TabIndex = 31;
            this.button_logout.Text = "LOG OUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 137);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1003, 450);
            this.panelControls.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.roundPictureBox_search);
            this.panel3.Location = new System.Drawing.Point(370, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 39);
            this.panel3.TabIndex = 34;
            // 
            // pictureBox_message
            // 
            this.pictureBox_message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_message.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_message.Image")));
            this.pictureBox_message.Location = new System.Drawing.Point(12, 37);
            this.pictureBox_message.Name = "pictureBox_message";
            this.pictureBox_message.Size = new System.Drawing.Size(48, 39);
            this.pictureBox_message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_message.TabIndex = 35;
            this.pictureBox_message.TabStop = false;
            this.pictureBox_message.Click += new System.EventHandler(this.pictureBox_message_Click);
            // 
            // Admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1003, 687);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel_ControlBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_panel";
            this.Load += new System.EventHandler(this.Admin_panel_Load);
            this.panel_ControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox_search)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private RoundPicturech roundPictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panelControls;
        public System.Windows.Forms.Button button_logout;
        public System.Windows.Forms.Label label_panelName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_message;
    }
}