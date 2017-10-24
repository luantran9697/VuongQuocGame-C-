namespace Caro
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
            this.lbTen = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMay = new System.Windows.Forms.Button();
            this.btNguoi = new System.Windows.Forms.Button();
            this.btChơiLai = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(-1, 1);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(925, 64);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "            GAME CARO";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(278, 85);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(630, 470);
            this.panel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btMay);
            this.groupBox1.Controls.Add(this.btNguoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ chơi";
            // 
            // btMay
            // 
            this.btMay.BackColor = System.Drawing.Color.Yellow;
            this.btMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMay.Location = new System.Drawing.Point(33, 110);
            this.btMay.Name = "btMay";
            this.btMay.Size = new System.Drawing.Size(161, 50);
            this.btMay.TabIndex = 0;
            this.btMay.Text = "Người với Máy";
            this.btMay.UseVisualStyleBackColor = false;
            // 
            // btNguoi
            // 
            this.btNguoi.BackColor = System.Drawing.Color.Yellow;
            this.btNguoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNguoi.Location = new System.Drawing.Point(33, 41);
            this.btNguoi.Name = "btNguoi";
            this.btNguoi.Size = new System.Drawing.Size(161, 50);
            this.btNguoi.TabIndex = 0;
            this.btNguoi.Text = "Người với Người";
            this.btNguoi.UseVisualStyleBackColor = false;
            // 
            // btChơiLai
            // 
            this.btChơiLai.BackColor = System.Drawing.Color.Red;
            this.btChơiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChơiLai.Location = new System.Drawing.Point(45, 311);
            this.btChơiLai.Name = "btChơiLai";
            this.btChơiLai.Size = new System.Drawing.Size(161, 50);
            this.btChơiLai.TabIndex = 0;
            this.btChơiLai.Text = "Chơi lại";
            this.btChơiLai.UseVisualStyleBackColor = false;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Location = new System.Drawing.Point(45, 392);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(161, 50);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caro.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(77, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btChơiLai);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMay;
        private System.Windows.Forms.Button btNguoi;
        private System.Windows.Forms.Button btChơiLai;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

