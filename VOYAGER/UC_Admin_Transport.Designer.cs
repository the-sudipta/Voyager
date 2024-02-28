
namespace VOYAGER
{
    partial class UC_Admin_Transport
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
            this.groupBox_transport = new System.Windows.Forms.GroupBox();
            this.radioButton_train = new System.Windows.Forms.RadioButton();
            this.radioButton_bus = new System.Windows.Forms.RadioButton();
            this.radioButton_air = new System.Windows.Forms.RadioButton();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_transport = new System.Windows.Forms.TextBox();
            this.label_transport = new System.Windows.Forms.Label();
            this.dataGridView_transport = new System.Windows.Forms.DataGridView();
            this.groupBox_transport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_transport
            // 
            this.groupBox_transport.Controls.Add(this.radioButton_train);
            this.groupBox_transport.Controls.Add(this.radioButton_bus);
            this.groupBox_transport.Controls.Add(this.radioButton_air);
            this.groupBox_transport.Controls.Add(this.button_update);
            this.groupBox_transport.Controls.Add(this.button_delete);
            this.groupBox_transport.Controls.Add(this.button_add);
            this.groupBox_transport.Controls.Add(this.textBox_transport);
            this.groupBox_transport.Controls.Add(this.label_transport);
            this.groupBox_transport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_transport.ForeColor = System.Drawing.Color.White;
            this.groupBox_transport.Location = new System.Drawing.Point(55, 146);
            this.groupBox_transport.Name = "groupBox_transport";
            this.groupBox_transport.Size = new System.Drawing.Size(485, 176);
            this.groupBox_transport.TabIndex = 6;
            this.groupBox_transport.TabStop = false;
            this.groupBox_transport.Text = "TRANSPORTS";
            // 
            // radioButton_train
            // 
            this.radioButton_train.AutoSize = true;
            this.radioButton_train.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_train.ForeColor = System.Drawing.Color.White;
            this.radioButton_train.Location = new System.Drawing.Point(351, 37);
            this.radioButton_train.Name = "radioButton_train";
            this.radioButton_train.Size = new System.Drawing.Size(66, 24);
            this.radioButton_train.TabIndex = 8;
            this.radioButton_train.TabStop = true;
            this.radioButton_train.Text = "TRAIN";
            this.radioButton_train.UseVisualStyleBackColor = true;
            this.radioButton_train.CheckedChanged += new System.EventHandler(this.radioButton_train_CheckedChanged);
            // 
            // radioButton_bus
            // 
            this.radioButton_bus.AutoSize = true;
            this.radioButton_bus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_bus.ForeColor = System.Drawing.Color.White;
            this.radioButton_bus.Location = new System.Drawing.Point(276, 37);
            this.radioButton_bus.Name = "radioButton_bus";
            this.radioButton_bus.Size = new System.Drawing.Size(54, 24);
            this.radioButton_bus.TabIndex = 7;
            this.radioButton_bus.TabStop = true;
            this.radioButton_bus.Text = "BUS";
            this.radioButton_bus.UseVisualStyleBackColor = true;
            this.radioButton_bus.CheckedChanged += new System.EventHandler(this.radioButton_bus_CheckedChanged);
            // 
            // radioButton_air
            // 
            this.radioButton_air.AutoSize = true;
            this.radioButton_air.Checked = true;
            this.radioButton_air.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_air.ForeColor = System.Drawing.Color.White;
            this.radioButton_air.Location = new System.Drawing.Point(211, 37);
            this.radioButton_air.Name = "radioButton_air";
            this.radioButton_air.Size = new System.Drawing.Size(49, 24);
            this.radioButton_air.TabIndex = 6;
            this.radioButton_air.TabStop = true;
            this.radioButton_air.Text = "AIR";
            this.radioButton_air.UseVisualStyleBackColor = true;
            this.radioButton_air.CheckedChanged += new System.EventHandler(this.radioButton_air_CheckedChanged);
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
            // textBox_transport
            // 
            this.textBox_transport.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_transport.Location = new System.Drawing.Point(174, 76);
            this.textBox_transport.Name = "textBox_transport";
            this.textBox_transport.Size = new System.Drawing.Size(283, 29);
            this.textBox_transport.TabIndex = 1;
            // 
            // label_transport
            // 
            this.label_transport.AutoSize = true;
            this.label_transport.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transport.ForeColor = System.Drawing.Color.White;
            this.label_transport.Location = new System.Drawing.Point(37, 79);
            this.label_transport.Name = "label_transport";
            this.label_transport.Size = new System.Drawing.Size(129, 22);
            this.label_transport.TabIndex = 0;
            this.label_transport.Text = "TRANSPORT";
            // 
            // dataGridView_transport
            // 
            this.dataGridView_transport.AllowUserToAddRows = false;
            this.dataGridView_transport.AllowUserToDeleteRows = false;
            this.dataGridView_transport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_transport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transport.Location = new System.Drawing.Point(597, 28);
            this.dataGridView_transport.Name = "dataGridView_transport";
            this.dataGridView_transport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_transport.Size = new System.Drawing.Size(350, 394);
            this.dataGridView_transport.TabIndex = 7;
            this.dataGridView_transport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_transport_CellContentClick);
            // 
            // UC_Admin_Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.groupBox_transport);
            this.Controls.Add(this.dataGridView_transport);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_Admin_Transport";
            this.Size = new System.Drawing.Size(1003, 450);
            this.groupBox_transport.ResumeLayout(false);
            this.groupBox_transport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_transport;
        private System.Windows.Forms.RadioButton radioButton_train;
        private System.Windows.Forms.RadioButton radioButton_bus;
        private System.Windows.Forms.RadioButton radioButton_air;
        public System.Windows.Forms.Button button_update;
        public System.Windows.Forms.Button button_delete;
        public System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_transport;
        private System.Windows.Forms.Label label_transport;
        private System.Windows.Forms.DataGridView dataGridView_transport;
    }
}
