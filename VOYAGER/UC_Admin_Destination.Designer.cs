
namespace VOYAGER
{
    partial class UC_Admin_Destination
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
            this.groupBox_destinations = new System.Windows.Forms.GroupBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_destination = new System.Windows.Forms.TextBox();
            this.label_destination = new System.Windows.Forms.Label();
            this.dataGridView_destination = new System.Windows.Forms.DataGridView();
            this.groupBox_destinations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_destination)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_destinations
            // 
            this.groupBox_destinations.Controls.Add(this.button_update);
            this.groupBox_destinations.Controls.Add(this.button_delete);
            this.groupBox_destinations.Controls.Add(this.button_add);
            this.groupBox_destinations.Controls.Add(this.textBox_destination);
            this.groupBox_destinations.Controls.Add(this.label_destination);
            this.groupBox_destinations.Font = new System.Drawing.Font("Arial", 11.25F);
            this.groupBox_destinations.ForeColor = System.Drawing.Color.White;
            this.groupBox_destinations.Location = new System.Drawing.Point(83, 145);
            this.groupBox_destinations.Name = "groupBox_destinations";
            this.groupBox_destinations.Size = new System.Drawing.Size(485, 176);
            this.groupBox_destinations.TabIndex = 0;
            this.groupBox_destinations.TabStop = false;
            this.groupBox_destinations.Text = "DESTINATIONS";
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
            // textBox_destination
            // 
            this.textBox_destination.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_destination.Location = new System.Drawing.Point(189, 76);
            this.textBox_destination.Name = "textBox_destination";
            this.textBox_destination.Size = new System.Drawing.Size(268, 29);
            this.textBox_destination.TabIndex = 1;
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_destination.ForeColor = System.Drawing.Color.White;
            this.label_destination.Location = new System.Drawing.Point(26, 75);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(139, 22);
            this.label_destination.TabIndex = 0;
            this.label_destination.Text = "DESTINATION";
            // 
            // dataGridView_destination
            // 
            this.dataGridView_destination.AllowUserToAddRows = false;
            this.dataGridView_destination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_destination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_destination.Location = new System.Drawing.Point(625, 27);
            this.dataGridView_destination.Name = "dataGridView_destination";
            this.dataGridView_destination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_destination.Size = new System.Drawing.Size(350, 394);
            this.dataGridView_destination.TabIndex = 1;
            this.dataGridView_destination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_destination_CellContentClick);
            // 
            // UC_Admin_Destination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dataGridView_destination);
            this.Controls.Add(this.groupBox_destinations);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_Admin_Destination";
            this.Size = new System.Drawing.Size(1003, 450);
            this.Load += new System.EventHandler(this.UC_Admin_Destination_Load);
            this.groupBox_destinations.ResumeLayout(false);
            this.groupBox_destinations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_destination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_destinations;
        private System.Windows.Forms.DataGridView dataGridView_destination;
        private System.Windows.Forms.TextBox textBox_destination;
        private System.Windows.Forms.Label label_destination;
        public System.Windows.Forms.Button button_add;
        public System.Windows.Forms.Button button_delete;
        public System.Windows.Forms.Button button_update;
    }
}
