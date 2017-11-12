namespace VuongQuocTroChoi
{
    partial class FormGameTinhToan
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
            this.lbldau = new System.Windows.Forms.Label();
            this.lblso2 = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldiem = new System.Windows.Forms.Label();
            this.lblthoigian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnthoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pichuongdan = new System.Windows.Forms.PictureBox();
            this.btndung = new System.Windows.Forms.Button();
            this.btnsai = new System.Windows.Forms.Button();
            this.lblso1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pichuongdan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldau
            // 
            this.lbldau.BackColor = System.Drawing.Color.White;
            this.lbldau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldau.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldau.Location = new System.Drawing.Point(142, 178);
            this.lbldau.Name = "lbldau";
            this.lbldau.Size = new System.Drawing.Size(78, 71);
            this.lbldau.TabIndex = 1;
            this.lbldau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblso2
            // 
            this.lblso2.BackColor = System.Drawing.Color.White;
            this.lblso2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblso2.ForeColor = System.Drawing.Color.Black;
            this.lblso2.Location = new System.Drawing.Point(262, 114);
            this.lblso2.Name = "lblso2";
            this.lblso2.Size = new System.Drawing.Size(89, 79);
            this.lblso2.TabIndex = 2;
            this.lblso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblketqua
            // 
            this.lblketqua.BackColor = System.Drawing.Color.White;
            this.lblketqua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblketqua.ForeColor = System.Drawing.Color.Black;
            this.lblketqua.Location = new System.Drawing.Point(415, 278);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(142, 81);
            this.lblketqua.TabIndex = 3;
            this.lblketqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(452, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Điểm số:";
            // 
            // lbldiem
            // 
            this.lbldiem.BackColor = System.Drawing.Color.White;
            this.lbldiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldiem.ForeColor = System.Drawing.Color.Red;
            this.lbldiem.Location = new System.Drawing.Point(422, 102);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(135, 69);
            this.lbldiem.TabIndex = 8;
            this.lbldiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblthoigian
            // 
            this.lblthoigian.BackColor = System.Drawing.Color.Transparent;
            this.lblthoigian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblthoigian.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblthoigian.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoigian.ForeColor = System.Drawing.Color.Black;
            this.lblthoigian.Location = new System.Drawing.Point(0, 0);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(688, 77);
            this.lblthoigian.TabIndex = 10;
            this.lblthoigian.Text = "          THIÊN TÀI TOÁN HỌC           ";
            this.lblthoigian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblthoigian.Click += new System.EventHandler(this.lblthoigian_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(579, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Chơi lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(579, 133);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 28);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pichuongdan
            // 
            this.pichuongdan.BackgroundImage = global::VuongQuocTroChoi.Properties.Resources.tải_xuống;
            this.pichuongdan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pichuongdan.Location = new System.Drawing.Point(639, 68);
            this.pichuongdan.Name = "pichuongdan";
            this.pichuongdan.Size = new System.Drawing.Size(28, 29);
            this.pichuongdan.TabIndex = 14;
            this.pichuongdan.TabStop = false;
            this.toolTip1.SetToolTip(this.pichuongdan, "Cho biết phép tính và kết quả đúng hay sai.\r\nNếu phép tính sai thì nhấn vào X\r\nNế" +
        "u phép tính đúng thì nhấn vào V");
            // 
            // btndung
            // 
            this.btndung.BackgroundImage = global::VuongQuocTroChoi.Properties.Resources._62778809_Tick_and_cross_signs_Green_checkmark_OK_and_red_X_icons_isolated__Stock_Photo__2_1;
            this.btndung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndung.Location = new System.Drawing.Point(323, 442);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(89, 82);
            this.btndung.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btndung, "Phép tính đúng");
            this.btndung.UseVisualStyleBackColor = true;
            this.btndung.Click += new System.EventHandler(this.btndung_Click);
            // 
            // btnsai
            // 
            this.btnsai.BackgroundImage = global::VuongQuocTroChoi.Properties.Resources._62778809_Tick_and_cross_signs_Green_checkmark_OK_and_red_X_icons_isolated__Stock_Photo__3_1;
            this.btnsai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsai.Location = new System.Drawing.Point(198, 442);
            this.btnsai.Name = "btnsai";
            this.btnsai.Size = new System.Drawing.Size(94, 82);
            this.btnsai.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnsai, "Phép tính sai");
            this.btnsai.UseVisualStyleBackColor = true;
            this.btnsai.Click += new System.EventHandler(this.btnsai_Click);
            // 
            // lblso1
            // 
            this.lblso1.BackColor = System.Drawing.Color.White;
            this.lblso1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblso1.ForeColor = System.Drawing.Color.Black;
            this.lblso1.Location = new System.Drawing.Point(32, 252);
            this.lblso1.Name = "lblso1";
            this.lblso1.Size = new System.Drawing.Size(91, 77);
            this.lblso1.TabIndex = 0;
            this.lblso1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGameTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::VuongQuocTroChoi.Properties.Resources.be_hoc_toan1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 582);
            this.Controls.Add(this.pichuongdan);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblthoigian);
            this.Controls.Add(this.lbldiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndung);
            this.Controls.Add(this.btnsai);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.lblso2);
            this.Controls.Add(this.lbldau);
            this.Controls.Add(this.lblso1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGameTinhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameTinhToan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameTinhToan_FormClosing);
            this.Load += new System.EventHandler(this.FormGameTinhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pichuongdan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblso1;
        private System.Windows.Forms.Label lbldau;
        private System.Windows.Forms.Label lblso2;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Button btnsai;
        private System.Windows.Forms.Button btndung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldiem;
        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pichuongdan;
    }
}