
namespace VOYAGER
{
    partial class UC_Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Hotel));
            this.button_singleBed = new System.Windows.Forms.Button();
            this.button_suite = new System.Windows.Forms.Button();
            this.button_packageSpecial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_singleBed
            // 
            this.button_singleBed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_singleBed.BackgroundImage")));
            this.button_singleBed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_singleBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_singleBed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_singleBed.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_singleBed.Location = new System.Drawing.Point(29, 78);
            this.button_singleBed.Name = "button_singleBed";
            this.button_singleBed.Size = new System.Drawing.Size(295, 270);
            this.button_singleBed.TabIndex = 0;
            this.button_singleBed.Text = "   SINGLE BED";
            this.button_singleBed.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_singleBed.UseVisualStyleBackColor = true;
            this.button_singleBed.Click += new System.EventHandler(this.button_singleBed_Click);
            // 
            // button_suite
            // 
            this.button_suite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_suite.BackgroundImage")));
            this.button_suite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_suite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_suite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_suite.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_suite.Location = new System.Drawing.Point(343, 78);
            this.button_suite.Name = "button_suite";
            this.button_suite.Size = new System.Drawing.Size(295, 270);
            this.button_suite.TabIndex = 1;
            this.button_suite.Text = "   SUITE";
            this.button_suite.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_suite.UseVisualStyleBackColor = true;
            this.button_suite.Click += new System.EventHandler(this.button_suite_Click);
            // 
            // button_packageSpecial
            // 
            this.button_packageSpecial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_packageSpecial.BackgroundImage")));
            this.button_packageSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_packageSpecial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_packageSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_packageSpecial.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_packageSpecial.Location = new System.Drawing.Point(658, 78);
            this.button_packageSpecial.Name = "button_packageSpecial";
            this.button_packageSpecial.Size = new System.Drawing.Size(295, 270);
            this.button_packageSpecial.TabIndex = 2;
            this.button_packageSpecial.Text = "    SPECIAL PACKAGE";
            this.button_packageSpecial.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_packageSpecial.UseVisualStyleBackColor = true;
            this.button_packageSpecial.Click += new System.EventHandler(this.button_packageSpecial_Click);
            // 
            // UC_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button_packageSpecial);
            this.Controls.Add(this.button_suite);
            this.Controls.Add(this.button_singleBed);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Hotel";
            this.Size = new System.Drawing.Size(987, 439);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_singleBed;
        private System.Windows.Forms.Button button_suite;
        private System.Windows.Forms.Button button_packageSpecial;
    }
}
