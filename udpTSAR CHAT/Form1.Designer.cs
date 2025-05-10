namespace udpTSAR_CHAT
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKarsiPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKarsiIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBaglanPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnConn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chiller", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(339, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 150);
            this.label1.TabIndex = 1;
            this.label1.Text = "TsarChat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1057, 684);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.txtKarsiPort);
            this.panel1.Controls.Add(this.txtKarsiIP);
            this.panel1.Controls.Add(this.txtBaglanPort);
            this.panel1.Controls.Add(this.BtnConn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(217, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 385);
            this.panel1.TabIndex = 3;
            // 
            // txtKarsiPort
            // 
            this.txtKarsiPort.Animated = true;
            this.txtKarsiPort.BorderRadius = 10;
            this.txtKarsiPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKarsiPort.DefaultText = "55106";
            this.txtKarsiPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKarsiPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKarsiPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKarsiPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKarsiPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtKarsiPort.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtKarsiPort.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txtKarsiPort.ForeColor = System.Drawing.Color.Silver;
            this.txtKarsiPort.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtKarsiPort.Location = new System.Drawing.Point(347, 197);
            this.txtKarsiPort.Margin = new System.Windows.Forms.Padding(4, 14, 4, 14);
            this.txtKarsiPort.Name = "txtKarsiPort";
            this.txtKarsiPort.PlaceholderText = "";
            this.txtKarsiPort.SelectedText = "";
            this.txtKarsiPort.Size = new System.Drawing.Size(244, 55);
            this.txtKarsiPort.TabIndex = 17;
            // 
            // txtKarsiIP
            // 
            this.txtKarsiIP.Animated = true;
            this.txtKarsiIP.BorderRadius = 10;
            this.txtKarsiIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKarsiIP.DefaultText = "192.168.1.48";
            this.txtKarsiIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKarsiIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKarsiIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKarsiIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKarsiIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtKarsiIP.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtKarsiIP.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txtKarsiIP.ForeColor = System.Drawing.Color.Silver;
            this.txtKarsiIP.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtKarsiIP.Location = new System.Drawing.Point(349, 114);
            this.txtKarsiIP.Margin = new System.Windows.Forms.Padding(4, 14, 4, 14);
            this.txtKarsiIP.Name = "txtKarsiIP";
            this.txtKarsiIP.PlaceholderText = "";
            this.txtKarsiIP.SelectedText = "";
            this.txtKarsiIP.Size = new System.Drawing.Size(244, 55);
            this.txtKarsiIP.TabIndex = 16;
            // 
            // txtBaglanPort
            // 
            this.txtBaglanPort.Animated = true;
            this.txtBaglanPort.BorderRadius = 10;
            this.txtBaglanPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBaglanPort.DefaultText = "55105";
            this.txtBaglanPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBaglanPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBaglanPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBaglanPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBaglanPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtBaglanPort.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtBaglanPort.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txtBaglanPort.ForeColor = System.Drawing.Color.Silver;
            this.txtBaglanPort.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtBaglanPort.Location = new System.Drawing.Point(349, 31);
            this.txtBaglanPort.Margin = new System.Windows.Forms.Padding(4, 14, 4, 14);
            this.txtBaglanPort.Name = "txtBaglanPort";
            this.txtBaglanPort.PlaceholderText = "";
            this.txtBaglanPort.SelectedText = "";
            this.txtBaglanPort.Size = new System.Drawing.Size(244, 55);
            this.txtBaglanPort.TabIndex = 15;
            // 
            // BtnConn
            // 
            this.BtnConn.Animated = true;
            this.BtnConn.BorderColor = System.Drawing.Color.Silver;
            this.BtnConn.BorderRadius = 15;
            this.BtnConn.BorderThickness = 1;
            this.BtnConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnConn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnConn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnConn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.BtnConn.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConn.ForeColor = System.Drawing.Color.White;
            this.BtnConn.Location = new System.Drawing.Point(347, 280);
            this.BtnConn.Name = "BtnConn";
            this.BtnConn.Size = new System.Drawing.Size(246, 65);
            this.BtnConn.TabIndex = 14;
            this.BtnConn.Text = "CONNECT";
            this.BtnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(18, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Karşı Tarafın Bağlandığı Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(18, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Karşı Tarafın IP Adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bağlanılacak Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1057, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TsarChatLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button BtnConn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtBaglanPort;
        public Guna.UI2.WinForms.Guna2TextBox txtKarsiPort;
        public Guna.UI2.WinForms.Guna2TextBox txtKarsiIP;
    }
}

