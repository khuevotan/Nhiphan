namespace CDNP
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(176, 121);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(135, 44);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 26;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(343, 132);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(135, 44);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 23;
            this.pic1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 36;
            this.button3.Text = "Chạy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button button3;
    }
}