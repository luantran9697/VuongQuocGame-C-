namespace VuongQuocTroChoi
{
    partial class FormGameTangBong
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbdokho = new System.Windows.Forms.ComboBox();
            this.btnbatdau = new System.Windows.Forms.Button();
            this.btntamdung = new System.Windows.Forms.Button();
            this.cbnhanvat = new System.Windows.Forms.ComboBox();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.lbldiem = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnchoilai = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picdobanh = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pichuongdan = new System.Windows.Forms.PictureBox();
            this.picbanh = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdobanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichuongdan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbdokho
            // 
            this.cbdokho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbdokho.FormattingEnabled = true;
            this.cbdokho.Items.AddRange(new object[] {
            "Dễ",
            "Trung Bình",
            "Khó"});
            this.cbdokho.Location = new System.Drawing.Point(12, 61);
            this.cbdokho.Name = "cbdokho";
            this.cbdokho.Size = new System.Drawing.Size(90, 27);
            this.cbdokho.TabIndex = 2;
            // 
            // btnbatdau
            // 
            this.btnbatdau.BackColor = System.Drawing.Color.White;
            this.btnbatdau.Location = new System.Drawing.Point(366, 54);
            this.btnbatdau.Name = "btnbatdau";
            this.btnbatdau.Size = new System.Drawing.Size(65, 23);
            this.btnbatdau.TabIndex = 3;
            this.btnbatdau.Text = "Bắt đầu";
            this.btnbatdau.UseVisualStyleBackColor = false;
            this.btnbatdau.Click += new System.EventHandler(this.btnbatdau_Click);
            // 
            // btntamdung
            // 
            this.btntamdung.BackColor = System.Drawing.Color.White;
            this.btntamdung.Location = new System.Drawing.Point(396, 25);
            this.btntamdung.Name = "btntamdung";
            this.btntamdung.Size = new System.Drawing.Size(75, 23);
            this.btntamdung.TabIndex = 4;
            this.btntamdung.Text = "Tạm dừng";
            this.btntamdung.UseVisualStyleBackColor = false;
            this.btntamdung.Click += new System.EventHandler(this.btntamdung_Click);
            // 
            // cbnhanvat
            // 
            this.cbnhanvat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbnhanvat.FormattingEnabled = true;
            this.cbnhanvat.Items.AddRange(new object[] {
            "Naruto",
            "Sasuke",
            "Sakura"});
            this.cbnhanvat.Location = new System.Drawing.Point(123, 61);
            this.cbnhanvat.Name = "cbnhanvat";
            this.cbnhanvat.Size = new System.Drawing.Size(90, 27);
            this.cbnhanvat.TabIndex = 5;
            // 
            // btntieptuc
            // 
            this.btntieptuc.BackColor = System.Drawing.Color.White;
            this.btntieptuc.Location = new System.Drawing.Point(477, 25);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(75, 23);
            this.btntieptuc.TabIndex = 6;
            this.btntieptuc.Text = "Tiếp tục";
            this.btntieptuc.UseVisualStyleBackColor = false;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // lbldiem
            // 
            this.lbldiem.BackColor = System.Drawing.Color.White;
            this.lbldiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldiem.ForeColor = System.Drawing.Color.Red;
            this.lbldiem.Location = new System.Drawing.Point(236, 31);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(70, 54);
            this.lbldiem.TabIndex = 7;
            this.lbldiem.Text = "0";
            this.lbldiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(325, 25);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(65, 23);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Độ khó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(118, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhân vật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(240, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Điểm số";
            // 
            // btnchoilai
            // 
            this.btnchoilai.BackColor = System.Drawing.Color.White;
            this.btnchoilai.Location = new System.Drawing.Point(437, 56);
            this.btnchoilai.Name = "btnchoilai";
            this.btnchoilai.Size = new System.Drawing.Size(75, 23);
            this.btnchoilai.TabIndex = 12;
            this.btnchoilai.Text = "Chơi lại";
            this.btnchoilai.UseVisualStyleBackColor = false;
            this.btnchoilai.Click += new System.EventHandler(this.btnchoilai_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Hướng dẫn!";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btntieptuc);
            this.groupBox1.Controls.Add(this.lbldiem);
            this.groupBox1.Controls.Add(this.pichuongdan);
            this.groupBox1.Controls.Add(this.cbnhanvat);
            this.groupBox1.Controls.Add(this.cbdokho);
            this.groupBox1.Controls.Add(this.btnchoilai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnbatdau);
            this.groupBox1.Controls.Add(this.btntamdung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Location = new System.Drawing.Point(188, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 94);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VuongQuocTroChoi.Properties.Resources.cloud_309024_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // picdobanh
            // 
            this.picdobanh.Image = global::VuongQuocTroChoi.Properties.Resources.naruto_sasuke_chibi__2_;
            this.picdobanh.Location = new System.Drawing.Point(152, 398);
            this.picdobanh.Name = "picdobanh";
            this.picdobanh.Size = new System.Drawing.Size(125, 194);
            this.picdobanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picdobanh.TabIndex = 0;
            this.picdobanh.TabStop = false;
            this.picdobanh.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picdobanh_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VuongQuocTroChoi.Properties.Resources._23477054_495467317475424_1249518400_n;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 546);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(928, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pichuongdan
            // 
            this.pichuongdan.BackgroundImage = global::VuongQuocTroChoi.Properties.Resources.tải_xuống;
            this.pichuongdan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pichuongdan.Location = new System.Drawing.Point(546, 65);
            this.pichuongdan.Name = "pichuongdan";
            this.pichuongdan.Size = new System.Drawing.Size(28, 29);
            this.pichuongdan.TabIndex = 13;
            this.pichuongdan.TabStop = false;
            this.toolTip1.SetToolTip(this.pichuongdan, "- Có thể chọn nhân vật và độ khó.\r\n- Di chuyển nhân vật bằng chuột hoặc phím trái" +
        ", phải để đỡ\r\nbóng không để bóng rơi.");
            // 
            // picbanh
            // 
            this.picbanh.Image = global::VuongQuocTroChoi.Properties.Resources.icon170x170;
            this.picbanh.Location = new System.Drawing.Point(177, 100);
            this.picbanh.Name = "picbanh";
            this.picbanh.Size = new System.Drawing.Size(61, 55);
            this.picbanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbanh.TabIndex = 1;
            this.picbanh.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VuongQuocTroChoi.Properties.Resources.cloud_309024_960_720;
            this.pictureBox2.Location = new System.Drawing.Point(768, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VuongQuocTroChoi.Properties.Resources.cloud_309024_960_720;
            this.pictureBox4.Location = new System.Drawing.Point(768, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // FormGameTangBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(928, 588);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picdobanh);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picbanh);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGameTangBong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameTangBong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameTangBong_FormClosing);
            this.Load += new System.EventHandler(this.FormGameTangBong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdobanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichuongdan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picdobanh;
        private System.Windows.Forms.PictureBox picbanh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbdokho;
        private System.Windows.Forms.Button btnbatdau;
        private System.Windows.Forms.Button btntamdung;
        private System.Windows.Forms.ComboBox cbnhanvat;
        private System.Windows.Forms.Button btntieptuc;
        private System.Windows.Forms.Label lbldiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnchoilai;
        private System.Windows.Forms.PictureBox pichuongdan;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}