
namespace VOYAGER
{
    partial class UC_Destination_Monuments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Destination_Monuments));
            this.label_monuments = new System.Windows.Forms.Label();
            this.panel_dhaka = new System.Windows.Forms.Panel();
            this.label_dhaka = new System.Windows.Forms.Label();
            this.panel_monuments = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_dhaka.SuspendLayout();
            this.panel_monuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_monuments
            // 
            this.label_monuments.AutoSize = true;
            this.label_monuments.BackColor = System.Drawing.Color.Transparent;
            this.label_monuments.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_monuments.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_monuments.Location = new System.Drawing.Point(3, 94);
            this.label_monuments.Name = "label_monuments";
            this.label_monuments.Size = new System.Drawing.Size(140, 29);
            this.label_monuments.TabIndex = 2;
            this.label_monuments.Text = "MONUMENTS";
            // 
            // panel_dhaka
            // 
            this.panel_dhaka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_dhaka.BackgroundImage")));
            this.panel_dhaka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_dhaka.Controls.Add(this.label_dhaka);
            this.panel_dhaka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_dhaka.Location = new System.Drawing.Point(384, 72);
            this.panel_dhaka.Name = "panel_dhaka";
            this.panel_dhaka.Size = new System.Drawing.Size(286, 144);
            this.panel_dhaka.TabIndex = 11;
            this.panel_dhaka.Click += new System.EventHandler(this.panel_dhaka_Click);
            // 
            // label_dhaka
            // 
            this.label_dhaka.AutoSize = true;
            this.label_dhaka.BackColor = System.Drawing.Color.Transparent;
            this.label_dhaka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_dhaka.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dhaka.Location = new System.Drawing.Point(16, 94);
            this.label_dhaka.Name = "label_dhaka";
            this.label_dhaka.Size = new System.Drawing.Size(83, 29);
            this.label_dhaka.TabIndex = 2;
            this.label_dhaka.Text = "DHAKA";
            this.label_dhaka.Click += new System.EventHandler(this.panel_dhaka_Click);
            // 
            // panel_monuments
            // 
            this.panel_monuments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_monuments.BackgroundImage")));
            this.panel_monuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_monuments.Controls.Add(this.label_monuments);
            this.panel_monuments.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_monuments.Location = new System.Drawing.Point(24, 72);
            this.panel_monuments.Name = "panel_monuments";
            this.panel_monuments.Size = new System.Drawing.Size(286, 144);
            this.panel_monuments.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Destination_Monuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel_dhaka);
            this.Controls.Add(this.panel_monuments);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Destination_Monuments";
            this.Size = new System.Drawing.Size(987, 439);
            this.panel_dhaka.ResumeLayout(false);
            this.panel_dhaka.PerformLayout();
            this.panel_monuments.ResumeLayout(false);
            this.panel_monuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_monuments;
        private System.Windows.Forms.Panel panel_dhaka;
        private System.Windows.Forms.Label label_dhaka;
        private System.Windows.Forms.Panel panel_monuments;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
