namespace Looshand
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.article_no_textbox = new System.Windows.Forms.TextBox();
            this.article_name_textbox = new System.Windows.Forms.TextBox();
            this.article_location_textbox = new System.Windows.Forms.TextBox();
            this.urun_bul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TL_textbox = new System.Windows.Forms.TextBox();
            this.connection_status_label = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(167, 235);
            this.barcode.MaxLength = 8;
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(221, 20);
            this.barcode.TabIndex = 3;
            this.barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barcode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(135, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scan Product Barcode or Type Barkode Manually";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // article_no_textbox
            // 
            this.article_no_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.article_no_textbox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.article_no_textbox.Location = new System.Drawing.Point(235, 37);
            this.article_no_textbox.Name = "article_no_textbox";
            this.article_no_textbox.Size = new System.Drawing.Size(345, 31);
            this.article_no_textbox.TabIndex = 9;
            this.article_no_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // article_name_textbox
            // 
            this.article_name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.article_name_textbox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article_name_textbox.Location = new System.Drawing.Point(237, 92);
            this.article_name_textbox.Multiline = true;
            this.article_name_textbox.Name = "article_name_textbox";
            this.article_name_textbox.Size = new System.Drawing.Size(343, 55);
            this.article_name_textbox.TabIndex = 10;
            this.article_name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // article_location_textbox
            // 
            this.article_location_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.article_location_textbox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.article_location_textbox.ForeColor = System.Drawing.Color.Red;
            this.article_location_textbox.Location = new System.Drawing.Point(237, 172);
            this.article_location_textbox.Name = "article_location_textbox";
            this.article_location_textbox.Size = new System.Drawing.Size(343, 31);
            this.article_location_textbox.TabIndex = 11;
            this.article_location_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // urun_bul
            // 
            this.urun_bul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.urun_bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_bul.Location = new System.Drawing.Point(409, 223);
            this.urun_bul.Name = "urun_bul";
            this.urun_bul.Size = new System.Drawing.Size(116, 41);
            this.urun_bul.TabIndex = 0;
            this.urun_bul.Text = "Find Product";
            this.urun_bul.UseVisualStyleBackColor = true;
            this.urun_bul.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.TL_textbox);
            this.groupBox1.Controls.Add(this.connection_status_label);
            this.groupBox1.Controls.Add(this.article_no_textbox);
            this.groupBox1.Controls.Add(this.article_name_textbox);
            this.groupBox1.Controls.Add(this.article_location_textbox);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 305);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // TL_textbox
            // 
            this.TL_textbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TL_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TL_textbox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TL_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TL_textbox.Location = new System.Drawing.Point(237, 234);
            this.TL_textbox.Name = "TL_textbox";
            this.TL_textbox.ReadOnly = true;
            this.TL_textbox.Size = new System.Drawing.Size(343, 31);
            this.TL_textbox.TabIndex = 18;
            this.TL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connection_status_label
            // 
            this.connection_status_label.AutoSize = true;
            this.connection_status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connection_status_label.Location = new System.Drawing.Point(472, 286);
            this.connection_status_label.Name = "connection_status_label";
            this.connection_status_label.Size = new System.Drawing.Size(93, 13);
            this.connection_status_label.TabIndex = 17;
            this.connection_status_label.Text = "Disconnected !";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(6, 34);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(219, 235);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(428, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(533, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = " Version 1.1.0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::BarcodeScanner.Properties.Resources.ic_barcode_scanner;
            this.pictureBox7.Location = new System.Drawing.Point(249, 45);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(107, 66);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(91, 178);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(460, 106);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(603, 138);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox6.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(626, 164);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarcodeScanner.Properties.Resources.anil_avci_qr;
            this.pictureBox1.Location = new System.Drawing.Point(544, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BarcodeScanner.Properties.Resources.offline;
            this.pictureBox2.Location = new System.Drawing.Point(565, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.urun_bul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(625, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urun_bul);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urun_bul;
        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox article_no_textbox;
        private System.Windows.Forms.TextBox article_name_textbox;
        private System.Windows.Forms.TextBox article_location_textbox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label connection_status_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TL_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

