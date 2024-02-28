
namespace VOYAGER
{
    partial class UC_Transport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Transport));
            this.panel_air = new System.Windows.Forms.Panel();
            this.label_air = new System.Windows.Forms.Label();
            this.panel_bus = new System.Windows.Forms.Panel();
            this.label_bus = new System.Windows.Forms.Label();
            this.panel_train = new System.Windows.Forms.Panel();
            this.label_train = new System.Windows.Forms.Label();
            this.panel_all_travel_details_container = new System.Windows.Forms.Panel();
            this.panel_right_padding = new System.Windows.Forms.Panel();
            this.panel_train_details = new System.Windows.Forms.Panel();
            this.comboBox_train = new System.Windows.Forms.ComboBox();
            this.panel_bus_details = new System.Windows.Forms.Panel();
            this.comboBox_bus = new System.Windows.Forms.ComboBox();
            this.panel_air_details = new System.Windows.Forms.Panel();
            this.comboBox_air = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_air.SuspendLayout();
            this.panel_bus.SuspendLayout();
            this.panel_train.SuspendLayout();
            this.panel_all_travel_details_container.SuspendLayout();
            this.panel_train_details.SuspendLayout();
            this.panel_bus_details.SuspendLayout();
            this.panel_air_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_air
            // 
            this.panel_air.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_air.BackgroundImage")));
            this.panel_air.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_air.Controls.Add(this.label_air);
            this.panel_air.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_air.Location = new System.Drawing.Point(34, 75);
            this.panel_air.Name = "panel_air";
            this.panel_air.Size = new System.Drawing.Size(295, 270);
            this.panel_air.TabIndex = 0;
            this.panel_air.Click += new System.EventHandler(this.panel_air_Click);
            // 
            // label_air
            // 
            this.label_air.BackColor = System.Drawing.Color.Transparent;
            this.label_air.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_air.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_air.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_air.Location = new System.Drawing.Point(0, 232);
            this.label_air.Name = "label_air";
            this.label_air.Size = new System.Drawing.Size(295, 38);
            this.label_air.TabIndex = 0;
            this.label_air.Text = "     AIR";
            this.label_air.Click += new System.EventHandler(this.panel_air_Click);
            // 
            // panel_bus
            // 
            this.panel_bus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_bus.BackgroundImage")));
            this.panel_bus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_bus.Controls.Add(this.label_bus);
            this.panel_bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_bus.Location = new System.Drawing.Point(346, 75);
            this.panel_bus.Name = "panel_bus";
            this.panel_bus.Size = new System.Drawing.Size(295, 270);
            this.panel_bus.TabIndex = 1;
            this.panel_bus.Click += new System.EventHandler(this.panel_bus_Click);
            // 
            // label_bus
            // 
            this.label_bus.BackColor = System.Drawing.Color.Transparent;
            this.label_bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_bus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bus.Location = new System.Drawing.Point(0, 232);
            this.label_bus.Name = "label_bus";
            this.label_bus.Size = new System.Drawing.Size(295, 38);
            this.label_bus.TabIndex = 1;
            this.label_bus.Text = "     BUS";
            this.label_bus.Click += new System.EventHandler(this.panel_bus_Click);
            // 
            // panel_train
            // 
            this.panel_train.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_train.BackgroundImage")));
            this.panel_train.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_train.Controls.Add(this.label_train);
            this.panel_train.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_train.Location = new System.Drawing.Point(658, 75);
            this.panel_train.Name = "panel_train";
            this.panel_train.Size = new System.Drawing.Size(295, 270);
            this.panel_train.TabIndex = 1;
            this.panel_train.Click += new System.EventHandler(this.panel_train_Click);
            // 
            // label_train
            // 
            this.label_train.BackColor = System.Drawing.Color.Transparent;
            this.label_train.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_train.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_train.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_train.Location = new System.Drawing.Point(0, 232);
            this.label_train.Name = "label_train";
            this.label_train.Size = new System.Drawing.Size(295, 38);
            this.label_train.TabIndex = 1;
            this.label_train.Text = "     TRAIN";
            this.label_train.Click += new System.EventHandler(this.panel_train_Click);
            // 
            // panel_all_travel_details_container
            // 
            this.panel_all_travel_details_container.Controls.Add(this.panel_right_padding);
            this.panel_all_travel_details_container.Controls.Add(this.panel_train_details);
            this.panel_all_travel_details_container.Controls.Add(this.panel_bus_details);
            this.panel_all_travel_details_container.Controls.Add(this.panel_air_details);
            this.panel_all_travel_details_container.Controls.Add(this.panel1);
            this.panel_all_travel_details_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_all_travel_details_container.Location = new System.Drawing.Point(0, 351);
            this.panel_all_travel_details_container.Name = "panel_all_travel_details_container";
            this.panel_all_travel_details_container.Size = new System.Drawing.Size(987, 88);
            this.panel_all_travel_details_container.TabIndex = 2;
            // 
            // panel_right_padding
            // 
            this.panel_right_padding.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right_padding.Location = new System.Drawing.Point(956, 0);
            this.panel_right_padding.Name = "panel_right_padding";
            this.panel_right_padding.Size = new System.Drawing.Size(31, 88);
            this.panel_right_padding.TabIndex = 4;
            // 
            // panel_train_details
            // 
            this.panel_train_details.Controls.Add(this.comboBox_train);
            this.panel_train_details.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_train_details.Location = new System.Drawing.Point(654, 0);
            this.panel_train_details.Name = "panel_train_details";
            this.panel_train_details.Size = new System.Drawing.Size(299, 88);
            this.panel_train_details.TabIndex = 3;
            // 
            // comboBox_train
            // 
            this.comboBox_train.BackColor = System.Drawing.Color.Black;
            this.comboBox_train.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_train.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_train.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_train.ForeColor = System.Drawing.Color.White;
            this.comboBox_train.FormattingEnabled = true;
            this.comboBox_train.Location = new System.Drawing.Point(9, 30);
            this.comboBox_train.Name = "comboBox_train";
            this.comboBox_train.Size = new System.Drawing.Size(278, 33);
            this.comboBox_train.TabIndex = 0;
            this.comboBox_train.Visible = false;
            this.comboBox_train.TextChanged += new System.EventHandler(this.comboBox_train_TextChanged);
            // 
            // panel_bus_details
            // 
            this.panel_bus_details.Controls.Add(this.comboBox_bus);
            this.panel_bus_details.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bus_details.Location = new System.Drawing.Point(343, 0);
            this.panel_bus_details.Name = "panel_bus_details";
            this.panel_bus_details.Size = new System.Drawing.Size(311, 88);
            this.panel_bus_details.TabIndex = 2;
            // 
            // comboBox_bus
            // 
            this.comboBox_bus.BackColor = System.Drawing.Color.Black;
            this.comboBox_bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_bus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_bus.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_bus.ForeColor = System.Drawing.Color.White;
            this.comboBox_bus.FormattingEnabled = true;
            this.comboBox_bus.Location = new System.Drawing.Point(9, 30);
            this.comboBox_bus.Name = "comboBox_bus";
            this.comboBox_bus.Size = new System.Drawing.Size(278, 33);
            this.comboBox_bus.TabIndex = 0;
            this.comboBox_bus.Visible = false;
            this.comboBox_bus.TextChanged += new System.EventHandler(this.comboBox_bus_TextChanged);
            // 
            // panel_air_details
            // 
            this.panel_air_details.Controls.Add(this.comboBox_air);
            this.panel_air_details.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_air_details.Location = new System.Drawing.Point(33, 0);
            this.panel_air_details.Name = "panel_air_details";
            this.panel_air_details.Size = new System.Drawing.Size(310, 88);
            this.panel_air_details.TabIndex = 1;
            // 
            // comboBox_air
            // 
            this.comboBox_air.BackColor = System.Drawing.Color.Black;
            this.comboBox_air.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_air.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_air.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_air.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_air.ForeColor = System.Drawing.Color.White;
            this.comboBox_air.FormattingEnabled = true;
            this.comboBox_air.Location = new System.Drawing.Point(9, 30);
            this.comboBox_air.Name = "comboBox_air";
            this.comboBox_air.Size = new System.Drawing.Size(278, 33);
            this.comboBox_air.TabIndex = 0;
            this.comboBox_air.Visible = false;
            this.comboBox_air.TextChanged += new System.EventHandler(this.comboBox_air_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 88);
            this.panel1.TabIndex = 0;
            // 
            // UC_Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel_all_travel_details_container);
            this.Controls.Add(this.panel_train);
            this.Controls.Add(this.panel_bus);
            this.Controls.Add(this.panel_air);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Transport";
            this.Size = new System.Drawing.Size(987, 439);
            this.panel_air.ResumeLayout(false);
            this.panel_bus.ResumeLayout(false);
            this.panel_train.ResumeLayout(false);
            this.panel_all_travel_details_container.ResumeLayout(false);
            this.panel_train_details.ResumeLayout(false);
            this.panel_bus_details.ResumeLayout(false);
            this.panel_air_details.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_air;
        private System.Windows.Forms.Panel panel_bus;
        private System.Windows.Forms.Panel panel_train;
        private System.Windows.Forms.Label label_air;
        private System.Windows.Forms.Label label_bus;
        private System.Windows.Forms.Label label_train;
        private System.Windows.Forms.Panel panel_all_travel_details_container;
        private System.Windows.Forms.Panel panel_air_details;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_air;
        private System.Windows.Forms.Panel panel_right_padding;
        private System.Windows.Forms.Panel panel_train_details;
        private System.Windows.Forms.ComboBox comboBox_train;
        private System.Windows.Forms.Panel panel_bus_details;
        private System.Windows.Forms.ComboBox comboBox_bus;
    }
}
