
namespace VOYAGER
{
    partial class UC_Admin_AllHistory_Next
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Admin_AllHistory_Next));
            this.dataGridView_client = new System.Windows.Forms.DataGridView();
            this.dataGridView_staff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundPicturech_back = new VOYAGER.RoundPicturech();
            this.dataGridView_tour = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturech_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tour)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_client
            // 
            this.dataGridView_client.AllowUserToAddRows = false;
            this.dataGridView_client.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_client.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_client.Location = new System.Drawing.Point(276, 0);
            this.dataGridView_client.Name = "dataGridView_client";
            this.dataGridView_client.Size = new System.Drawing.Size(593, 405);
            this.dataGridView_client.TabIndex = 19;
            // 
            // dataGridView_staff
            // 
            this.dataGridView_staff.AllowUserToAddRows = false;
            this.dataGridView_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_staff.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_staff.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_staff.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_staff.Name = "dataGridView_staff";
            this.dataGridView_staff.Size = new System.Drawing.Size(276, 405);
            this.dataGridView_staff.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundPicturech_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 45);
            this.panel1.TabIndex = 14;
            // 
            // roundPicturech_back
            // 
            this.roundPicturech_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundPicturech_back.Image = ((System.Drawing.Image)(resources.GetObject("roundPicturech_back.Image")));
            this.roundPicturech_back.Location = new System.Drawing.Point(951, 4);
            this.roundPicturech_back.Name = "roundPicturech_back";
            this.roundPicturech_back.Size = new System.Drawing.Size(36, 35);
            this.roundPicturech_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundPicturech_back.TabIndex = 0;
            this.roundPicturech_back.TabStop = false;
            this.roundPicturech_back.Click += new System.EventHandler(this.roundPicturech_back_Click);
            // 
            // dataGridView_tour
            // 
            this.dataGridView_tour.AllowUserToAddRows = false;
            this.dataGridView_tour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tour.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_tour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tour.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_tour.Location = new System.Drawing.Point(869, 0);
            this.dataGridView_tour.Name = "dataGridView_tour";
            this.dataGridView_tour.Size = new System.Drawing.Size(132, 405);
            this.dataGridView_tour.TabIndex = 20;
            // 
            // UC_Admin_AllHistory_Next
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dataGridView_tour);
            this.Controls.Add(this.dataGridView_client);
            this.Controls.Add(this.dataGridView_staff);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_Admin_AllHistory_Next";
            this.Size = new System.Drawing.Size(1003, 450);
            this.Load += new System.EventHandler(this.UC_Admin_AllHistory_Next_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturech_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_client;
        private System.Windows.Forms.DataGridView dataGridView_staff;
        private System.Windows.Forms.Panel panel1;
        private RoundPicturech roundPicturech_back;
        private System.Windows.Forms.DataGridView dataGridView_tour;
    }
}
