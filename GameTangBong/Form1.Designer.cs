namespace GameTangBong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btContinue = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.btAgain = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btAgain);
            this.panel1.Controls.Add(this.btEnd);
            this.panel1.Controls.Add(this.btContinue);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.lbDiem);
            this.panel1.Controls.Add(this.lb3);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 87);
            this.panel1.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb1.Location = new System.Drawing.Point(24, 27);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(56, 16);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Độ khó";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb2.Location = new System.Drawing.Point(127, 27);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(69, 16);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Nhân vật";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb3.Location = new System.Drawing.Point(285, 13);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(64, 16);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "Điểm số";
            // 
            // btStart
            // 
            this.btStart.AutoSize = true;
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btStart.Location = new System.Drawing.Point(418, 20);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Bắt đầu";
            this.btStart.UseVisualStyleBackColor = false;
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btStop.Location = new System.Drawing.Point(517, 20);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Bắt đầu";
            this.btStop.UseVisualStyleBackColor = false;
            // 
            // btContinue
            // 
            this.btContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btContinue.Location = new System.Drawing.Point(613, 20);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(75, 23);
            this.btContinue.TabIndex = 1;
            this.btContinue.Text = "Tiếp tục";
            this.btContinue.UseVisualStyleBackColor = false;
            // 
            // btEnd
            // 
            this.btEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btEnd.Location = new System.Drawing.Point(459, 61);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(75, 23);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "Thoát";
            this.btEnd.UseVisualStyleBackColor = false;
            // 
            // btAgain
            // 
            this.btAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAgain.Location = new System.Drawing.Point(566, 61);
            this.btAgain.Name = "btAgain";
            this.btAgain.Size = new System.Drawing.Size(75, 23);
            this.btAgain.TabIndex = 1;
            this.btAgain.Text = "Chơi lại";
            this.btAgain.UseVisualStyleBackColor = false;
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiem.Location = new System.Drawing.Point(274, 29);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(86, 48);
            this.lbDiem.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(707, 367);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameTangBong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btAgain;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

