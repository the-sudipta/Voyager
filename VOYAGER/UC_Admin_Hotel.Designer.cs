
namespace VOYAGER
{
    partial class UC_Admin_Hotel
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
            this.groupBox_hotel = new System.Windows.Forms.GroupBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_hotel = new System.Windows.Forms.TextBox();
            this.label_hotel = new System.Windows.Forms.Label();
            this.dataGridView_hotel = new System.Windows.Forms.DataGridView();
            this.groupBox_hotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_hotel
            // 
            this.groupBox_hotel.Controls.Add(this.button_update);
            this.groupBox_hotel.Controls.Add(this.button_delete);
            this.groupBox_hotel.Controls.Add(this.button_add);
            this.groupBox_hotel.Controls.Add(this.textBox_hotel);
            this.groupBox_hotel.Controls.Add(this.label_hotel);
            this.groupBox_hotel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.groupBox_hotel.ForeColor = System.Drawing.Color.White;
            this.groupBox_hotel.Location = new System.Drawing.Point(55, 146);
            this.groupBox_hotel.Name = "groupBox_hotel";
            this.groupBox_hotel.Size = new System.Drawing.Size(485, 176);
            this.groupBox_hotel.TabIndex = 2;
            this.groupBox_hotel.TabStop = false;
            this.groupBox_hotel.Text = "HOTELS";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.White;
            this.button_update.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.Black;
            this.button_update.Location = new System.Drawing.Point(197, 123);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(123, 36);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(334, 123);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(123, 36);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(58, 123);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(123, 36);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "ADD NEW";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_hotel
            // 
            this.textBox_hotel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hotel.Location = new System.Drawing.Point(157, 76);
            this.textBox_hotel.Name = "textBox_hotel";
            this.textBox_hotel.Size = new System.Drawing.Size(300, 29);
            this.textBox_hotel.TabIndex = 1;
            // 
            // label_hotel
            // 
            this.label_hotel.AutoSize = true;
            this.label_hotel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hotel.ForeColor = System.Drawing.Color.White;
            this.label_hotel.Location = new System.Drawing.Point(77, 76);
            this.label_hotel.Name = "label_hotel";
            this.label_hotel.Size = new System.Drawing.Size(76, 22);
            this.label_hotel.TabIndex = 0;
            this.label_hotel.Text = "HOTEL";
            // 
            // dataGridView_hotel
            // 
            this.dataGridView_hotel.AllowUserToAddRows = false;
            this.dataGridView_hotel.AllowUserToDeleteRows = false;
            this.dataGridView_hotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hotel.Location = new System.Drawing.Point(597, 28);
            this.dataGridView_hotel.Name = "dataGridView_hotel";
            this.dataGridView_hotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hotel.Size = new System.Drawing.Size(350, 394);
            this.dataGridView_hotel.TabIndex = 3;
            this.dataGridView_hotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hotel_CellContentClick);
            // 
            // UC_Admin_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.groupBox_hotel);
            this.Controls.Add(this.dataGridView_hotel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_Admin_Hotel";
            this.Size = new System.Drawing.Size(1003, 450);
            this.groupBox_hotel.ResumeLayout(false);
            this.groupBox_hotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_hotel;
        private System.Windows.Forms.TextBox textBox_hotel;
        private System.Windows.Forms.Label label_hotel;
        private System.Windows.Forms.DataGridView dataGridView_hotel;
        public System.Windows.Forms.Button button_update;
        public System.Windows.Forms.Button button_delete;
        public System.Windows.Forms.Button button_add;
    }
}
