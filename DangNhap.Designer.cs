namespace VuongQuocTroChoi
{
    partial class DangNhap
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
            this.lblthoigian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsigin = new System.Windows.Forms.Button();
            this.btnsigup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblthoigian
            // 
            this.lblthoigian.BackColor = System.Drawing.Color.Black;
            this.lblthoigian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblthoigian.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblthoigian.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoigian.ForeColor = System.Drawing.Color.Transparent;
            this.lblthoigian.Location = new System.Drawing.Point(0, 0);
            this.lblthoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(648, 75);
            this.lblthoigian.TabIndex = 17;
            this.lblthoigian.Text = "        ĐĂNG NHẬP      ";
            this.lblthoigian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txttendangnhap.ForeColor = System.Drawing.Color.White;
            this.txttendangnhap.Location = new System.Drawing.Point(401, 145);
            this.txttendangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(188, 22);
            this.txttendangnhap.TabIndex = 18;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(401, 201);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(188, 22);
            this.txtpass.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(223, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            // 
            // btnsigin
            // 
            this.btnsigin.BackColor = System.Drawing.Color.LightGray;
            this.btnsigin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsigin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsigin.Location = new System.Drawing.Point(491, 263);
            this.btnsigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsigin.Name = "btnsigin";
            this.btnsigin.Size = new System.Drawing.Size(100, 43);
            this.btnsigin.TabIndex = 22;
            this.btnsigin.Text = "Sign in";
            this.btnsigin.UseVisualStyleBackColor = false;
            this.btnsigin.Click += new System.EventHandler(this.btnsigin_Click);
            // 
            // btnsigup
            // 
            this.btnsigup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsigup.Location = new System.Drawing.Point(301, 265);
            this.btnsigup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsigup.Name = "btnsigup";
            this.btnsigup.Size = new System.Drawing.Size(100, 42);
            this.btnsigup.TabIndex = 23;
            this.btnsigup.Text = "Sign up";
            this.btnsigup.UseVisualStyleBackColor = true;
            this.btnsigup.Click += new System.EventHandler(this.btnsigup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::VuongQuocTroChoi.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(648, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsigup);
            this.Controls.Add(this.btnsigin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.lblthoigian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsigin;
        private System.Windows.Forms.Button btnsigup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}