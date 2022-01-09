namespace CDNP
{
    partial class Form5
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo6 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "==>";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(46, 318);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(158, 26);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(298, 321);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(158, 26);
            this.txt2.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(46, 400);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(126, 40);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Chuyển đổi";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(209, 400);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 40);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Xóa";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(358, 400);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(87, 40);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Thoát";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(10, 97);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(111, 24);
            this.rdo1.TabIndex = 6;
            this.rdo1.Text = "Thập Phân";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Checked = true;
            this.rdo2.Location = new System.Drawing.Point(10, 55);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(98, 24);
            this.rdo2.TabIndex = 7;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "Nhị Phân";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết quả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo5);
            this.groupBox1.Controls.Add(this.rdo1);
            this.groupBox1.Controls.Add(this.rdo2);
            this.groupBox1.Location = new System.Drawing.Point(46, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển từ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo6);
            this.groupBox2.Controls.Add(this.rdo4);
            this.groupBox2.Controls.Add(this.rdo3);
            this.groupBox2.Location = new System.Drawing.Point(298, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 187);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sang";
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Checked = true;
            this.rdo4.Location = new System.Drawing.Point(6, 99);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(111, 24);
            this.rdo4.TabIndex = 6;
            this.rdo4.TabStop = true;
            this.rdo4.Text = "Thập Phân";
            this.rdo4.UseVisualStyleBackColor = true;
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(6, 48);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(98, 24);
            this.rdo3.TabIndex = 7;
            this.rdo3.Text = "Nhị Phân";
            this.rdo3.UseVisualStyleBackColor = true;
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(10, 141);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(141, 24);
            this.rdo5.TabIndex = 8;
            this.rdo5.Text = "Thập Lục Phân";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // rdo6
            // 
            this.rdo6.AutoSize = true;
            this.rdo6.Location = new System.Drawing.Point(6, 143);
            this.rdo6.Name = "rdo6";
            this.rdo6.Size = new System.Drawing.Size(141, 24);
            this.rdo6.TabIndex = 9;
            this.rdo6.Text = "Thập Lục Phân";
            this.rdo6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(162, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "CHUYỂN ĐỔI";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 464);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Chuyển đổi đơn giản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo6;
        private System.Windows.Forms.Label label4;
    }
}