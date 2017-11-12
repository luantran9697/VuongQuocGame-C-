namespace VuongQuocTroChoi
{
    partial class ThongKeKetQua
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
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnquay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvthongke
            // 
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Location = new System.Drawing.Point(301, 106);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.Size = new System.Drawing.Size(289, 209);
            this.dgvthongke.TabIndex = 0;
            this.dgvthongke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthongke_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VuongQuocTroChoi.Properties.Resources.a;
            this.pictureBox1.Location = new System.Drawing.Point(227, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnquay
            // 
            this.btnquay.ForeColor = System.Drawing.Color.Black;
            this.btnquay.Location = new System.Drawing.Point(595, 25);
            this.btnquay.Name = "btnquay";
            this.btnquay.Size = new System.Drawing.Size(66, 24);
            this.btnquay.TabIndex = 4;
            this.btnquay.Text = "Quay lại";
            this.btnquay.UseVisualStyleBackColor = true;
            this.btnquay.Click += new System.EventHandler(this.btnquay_Click);
            // 
            // ThongKeKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::VuongQuocTroChoi.Properties.Resources._7647100_stock_vector_pirate_cartoon_beach_sign_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 378);
            this.ControlBox = false;
            this.Controls.Add(this.btnquay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvthongke);
            this.Name = "ThongKeKetQua";
            this.Text = "ThongKeKetQua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongKeKetQua_FormClosing);
            this.Load += new System.EventHandler(this.ThongKeKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnquay;
    }
}