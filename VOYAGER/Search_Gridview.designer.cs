
namespace VOYAGER
{
    partial class Search_Gridview
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
            this.button_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_searched_data = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searched_data)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.White;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(234, 9);
            this.button_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(201, 49);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "OK";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 68);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView_searched_data
            // 
            this.dataGridView_searched_data.AllowUserToAddRows = false;
            this.dataGridView_searched_data.AllowUserToDeleteRows = false;
            this.dataGridView_searched_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_searched_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_searched_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_searched_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_searched_data.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_searched_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_searched_data.Name = "dataGridView_searched_data";
            this.dataGridView_searched_data.RowHeadersWidth = 62;
            this.dataGridView_searched_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_searched_data.Size = new System.Drawing.Size(675, 304);
            this.dataGridView_searched_data.TabIndex = 4;
            // 
            // Search_Gridview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(675, 372);
            this.Controls.Add(this.dataGridView_searched_data);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search_Gridview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Gridview";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searched_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_searched_data;
    }
}