namespace CDNP
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(687, 157);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 39);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Chạy";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(687, 227);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 39);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Chạy";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(687, 284);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 47);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Chạy";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(347, 437);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(116, 61);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Thoát";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(35, 166);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(550, 20);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Hiển thị lần lượt các dãy nhị phân biểu diễn số nguyên theo thứ tự 0,1,… 2^n -1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(35, 236);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(618, 20);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Nhập file văn bản chứa số nguyên n<=100 và ghi ra file chứa các dãy nhị phân độ d" +
    "ài n.";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(35, 297);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(597, 20);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Liệt kê các dãy nhị phần độ dài n mà trong đó cụm chữ số “01” xuất hiện đúng 2 lầ" +
    "n.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(271, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chuyển Đổi Cơ Số";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(35, 357);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(153, 20);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Chuyển đổi đơn giản";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(221, 344);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 47);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "Chạy";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 55);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển đổi nhị phân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Panel panel1;
    }
}

