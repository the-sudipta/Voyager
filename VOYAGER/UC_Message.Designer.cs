
namespace VOYAGER
{
    partial class UC_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Message));
            this.label_getMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundPicturech_send = new VOYAGER.RoundPicturech();
            this.textBox_sendMessage = new System.Windows.Forms.TextBox();
            this.label_myMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturech_send)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_getMessage
            // 
            this.label_getMessage.BackColor = System.Drawing.Color.Black;
            this.label_getMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_getMessage.ForeColor = System.Drawing.Color.White;
            this.label_getMessage.Location = new System.Drawing.Point(10, 98);
            this.label_getMessage.Name = "label_getMessage";
            this.label_getMessage.Size = new System.Drawing.Size(274, 149);
            this.label_getMessage.TabIndex = 2;
            this.label_getMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundPicturech_send);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(947, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 450);
            this.panel1.TabIndex = 3;
            // 
            // roundPicturech_send
            // 
            this.roundPicturech_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundPicturech_send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundPicturech_send.Image = ((System.Drawing.Image)(resources.GetObject("roundPicturech_send.Image")));
            this.roundPicturech_send.Location = new System.Drawing.Point(0, 380);
            this.roundPicturech_send.Name = "roundPicturech_send";
            this.roundPicturech_send.Size = new System.Drawing.Size(56, 70);
            this.roundPicturech_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundPicturech_send.TabIndex = 6;
            this.roundPicturech_send.TabStop = false;
            this.roundPicturech_send.Click += new System.EventHandler(this.roundPicturech_send_Click);
            // 
            // textBox_sendMessage
            // 
            this.textBox_sendMessage.BackColor = System.Drawing.Color.Black;
            this.textBox_sendMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sendMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sendMessage.ForeColor = System.Drawing.Color.Silver;
            this.textBox_sendMessage.Location = new System.Drawing.Point(3, 4);
            this.textBox_sendMessage.Multiline = true;
            this.textBox_sendMessage.Name = "textBox_sendMessage";
            this.textBox_sendMessage.Size = new System.Drawing.Size(938, 51);
            this.textBox_sendMessage.TabIndex = 4;
            this.textBox_sendMessage.Text = "Type your message here";
            this.textBox_sendMessage.Enter += new System.EventHandler(this.textBox_sendMessage_Enter);
            this.textBox_sendMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_sendMessage_KeyDown);
            this.textBox_sendMessage.Leave += new System.EventHandler(this.textBox_sendMessage_Leave);
            // 
            // label_myMessage
            // 
            this.label_myMessage.BackColor = System.Drawing.Color.Black;
            this.label_myMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_myMessage.ForeColor = System.Drawing.Color.White;
            this.label_myMessage.Location = new System.Drawing.Point(662, 238);
            this.label_myMessage.Name = "label_myMessage";
            this.label_myMessage.Size = new System.Drawing.Size(274, 149);
            this.label_myMessage.TabIndex = 5;
            this.label_myMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_sendMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 60);
            this.panel2.TabIndex = 6;
            // 
            // UC_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_myMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_getMessage);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_Message";
            this.Size = new System.Drawing.Size(1003, 450);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturech_send)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_getMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_sendMessage;
        private System.Windows.Forms.Label label_myMessage;
        private RoundPicturech roundPicturech_send;
        private System.Windows.Forms.Panel panel2;
    }
}
