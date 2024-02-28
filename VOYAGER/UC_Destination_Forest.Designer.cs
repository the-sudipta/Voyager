
namespace VOYAGER
{
    partial class UC_Destination_Forest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Destination_Forest));
            this.label_forest = new System.Windows.Forms.Label();
            this.panel_bandarban = new System.Windows.Forms.Panel();
            this.label_bandarban = new System.Windows.Forms.Label();
            this.panel_forest = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_bandarban.SuspendLayout();
            this.panel_forest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_forest
            // 
            this.label_forest.AutoSize = true;
            this.label_forest.BackColor = System.Drawing.Color.Transparent;
            this.label_forest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_forest.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forest.Location = new System.Drawing.Point(25, 94);
            this.label_forest.Name = "label_forest";
            this.label_forest.Size = new System.Drawing.Size(92, 29);
            this.label_forest.TabIndex = 2;
            this.label_forest.Text = "FOREST";
            // 
            // panel_bandarban
            // 
            this.panel_bandarban.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_bandarban.BackgroundImage")));
            this.panel_bandarban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_bandarban.Controls.Add(this.label_bandarban);
            this.panel_bandarban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_bandarban.Location = new System.Drawing.Point(384, 72);
            this.panel_bandarban.Name = "panel_bandarban";
            this.panel_bandarban.Size = new System.Drawing.Size(286, 144);
            this.panel_bandarban.TabIndex = 11;
            this.panel_bandarban.Click += new System.EventHandler(this.panel_bandarban_Click);
            // 
            // label_bandarban
            // 
            this.label_bandarban.AutoSize = true;
            this.label_bandarban.BackColor = System.Drawing.Color.Transparent;
            this.label_bandarban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bandarban.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bandarban.Location = new System.Drawing.Point(16, 94);
            this.label_bandarban.Name = "label_bandarban";
            this.label_bandarban.Size = new System.Drawing.Size(138, 29);
            this.label_bandarban.TabIndex = 2;
            this.label_bandarban.Text = "SUNDARBAN";
            this.label_bandarban.Click += new System.EventHandler(this.panel_bandarban_Click);
            // 
            // panel_forest
            // 
            this.panel_forest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_forest.BackgroundImage")));
            this.panel_forest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_forest.Controls.Add(this.label_forest);
            this.panel_forest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_forest.Location = new System.Drawing.Point(24, 72);
            this.panel_forest.Name = "panel_forest";
            this.panel_forest.Size = new System.Drawing.Size(286, 144);
            this.panel_forest.TabIndex = 10;
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
            // UC_Destination_Forest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel_bandarban);
            this.Controls.Add(this.panel_forest);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Destination_Forest";
            this.Size = new System.Drawing.Size(987, 439);
            this.panel_bandarban.ResumeLayout(false);
            this.panel_bandarban.PerformLayout();
            this.panel_forest.ResumeLayout(false);
            this.panel_forest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_forest;
        private System.Windows.Forms.Panel panel_bandarban;
        private System.Windows.Forms.Label label_bandarban;
        private System.Windows.Forms.Panel panel_forest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
