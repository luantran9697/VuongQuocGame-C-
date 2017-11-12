namespace VuongQuocTroChoi
{
    partial class FormGameBauCua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameBauCua));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttiencuoc = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lbltienconlai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnquay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbchon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pichuongdan = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblthoigian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichuongdan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.txttiencuoc);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.lbltienconlai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnquay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbchon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(430, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 454);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txttiencuoc
            // 
            this.txttiencuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttiencuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiencuoc.FormattingEnabled = true;
            this.txttiencuoc.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.txttiencuoc.Location = new System.Drawing.Point(33, 179);
            this.txttiencuoc.Name = "txttiencuoc";
            this.txttiencuoc.Size = new System.Drawing.Size(151, 29);
            this.txttiencuoc.TabIndex = 7;
            // 
            // btnthoat
            // 
            this.btnthoat.ForeColor = System.Drawing.Color.Black;
            this.btnthoat.Location = new System.Drawing.Point(33, 261);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(151, 38);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lbltienconlai
            // 
            this.lbltienconlai.BackColor = System.Drawing.Color.White;
            this.lbltienconlai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltienconlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltienconlai.ForeColor = System.Drawing.Color.Red;
            this.lbltienconlai.Image = global::VuongQuocTroChoi.Properties.Resources.decorative_1301811_960_7202;
            this.lbltienconlai.Location = new System.Drawing.Point(41, 337);
            this.lbltienconlai.Name = "lbltienconlai";
            this.lbltienconlai.Size = new System.Drawing.Size(143, 87);
            this.lbltienconlai.TabIndex = 5;
            this.lbltienconlai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiền còn lại";
            // 
            // btnquay
            // 
            this.btnquay.ForeColor = System.Drawing.Color.Black;
            this.btnquay.Location = new System.Drawing.Point(33, 214);
            this.btnquay.Name = "btnquay";
            this.btnquay.Size = new System.Drawing.Size(151, 41);
            this.btnquay.TabIndex = 3;
            this.btnquay.Text = "Xóc";
            this.btnquay.UseVisualStyleBackColor = true;
            this.btnquay.Click += new System.EventHandler(this.btnquay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền cược";
            // 
            // cbchon
            // 
            this.cbchon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbchon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchon.FormattingEnabled = true;
            this.cbchon.Items.AddRange(new object[] {
            "Bầu",
            "Cá",
            "Cua",
            "Gà",
            "Nai",
            "Tôm"});
            this.cbchon.Location = new System.Drawing.Point(33, 120);
            this.cbchon.Name = "cbchon";
            this.cbchon.Size = new System.Drawing.Size(151, 29);
            this.cbchon.TabIndex = 0;
            this.cbchon.SelectedIndexChanged += new System.EventHandler(this.cbchon_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pic3);
            this.groupBox1.Controls.Add(this.pic2);
            this.groupBox1.Controls.Add(this.pic1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(11, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // pic3
            // 
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic3.Location = new System.Drawing.Point(18, 46);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(101, 92);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic2.Location = new System.Drawing.Point(257, 46);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(101, 92);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic1.Location = new System.Drawing.Point(136, 46);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(101, 92);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::VuongQuocTroChoi.Properties.Resources.Backgrd;
            this.pictureBox1.Location = new System.Drawing.Point(17, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pichuongdan
            // 
            this.pichuongdan.BackColor = System.Drawing.Color.Transparent;
            this.pichuongdan.BackgroundImage = global::VuongQuocTroChoi.Properties.Resources._240px_Circle_question_red1;
            this.pichuongdan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pichuongdan.Image = global::VuongQuocTroChoi.Properties.Resources._240px_Circle_question_red_svg;
            this.pichuongdan.Location = new System.Drawing.Point(644, 21);
            this.pichuongdan.Name = "pichuongdan";
            this.pichuongdan.Size = new System.Drawing.Size(28, 29);
            this.pichuongdan.TabIndex = 14;
            this.pichuongdan.TabStop = false;
            this.toolTip1.SetToolTip(this.pichuongdan, resources.GetString("pichuongdan.ToolTip"));
            // 
            // lblthoigian
            // 
            this.lblthoigian.BackColor = System.Drawing.Color.Transparent;
            this.lblthoigian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblthoigian.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblthoigian.Font = new System.Drawing.Font("Harrington", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoigian.ForeColor = System.Drawing.Color.White;
            this.lblthoigian.Location = new System.Drawing.Point(0, 0);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(1048, 74);
            this.lblthoigian.TabIndex = 15;
            this.lblthoigian.Text = "          PHÁT TÀI PHÁT LỘC, VẠN SỰ NHƯ Ý            ";
            this.lblthoigian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(56, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FormGameBauCua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::VuongQuocTroChoi.Properties.Resources.Tet_2017_www_myvietnamvisapro_com_Vietnam_visa_during_Tet_Holiday;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 537);
            this.ControlBox = false;
            this.Controls.Add(this.lblthoigian);
            this.Controls.Add(this.pichuongdan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGameBauCua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameBauCua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameBauCua_FormClosing);
            this.Load += new System.EventHandler(this.FormGameBauCua_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichuongdan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltienconlai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnquay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbchon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.PictureBox pichuongdan;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox txttiencuoc;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}