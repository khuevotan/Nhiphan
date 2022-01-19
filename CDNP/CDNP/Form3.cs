using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CDNP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            FileStream stream = new FileStream(fileDialog.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(stream);
            string n;
            n = sr.ReadLine();
            sr.Close();
            lbl1.Text = n;
        }

        int [] a = new int[1000];
        string s;
        int n;

        void inra(int n)
        {
            for (int i = 1; i <= n; i++)
            {
		        s = s + Convert.ToString(a[i]);
	        }
            StreamWriter ghi = new StreamWriter("out2.txt", true);
            ghi.WriteLine(s);
            ghi.Close();
            rtxt1.Text = rtxt1.Text + Convert.ToString(s) + " ";
            s = "";
        }

        void deQuy(int i, int n)
        {
            for (int j = 0; j <= 1; j++)
            {
                a[i] = j;
                if (i == n)
                    inra(n);
                else
                    deQuy(i + 1, n);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            rtxt1.Text = "";
            int n = Convert.ToInt32(lbl1.Text);
            if (Convert.ToInt32(n) > 100 || Convert.ToInt32(n) <= 0)
              MessageBox.Show("Chú ý nhập lại n (0<n<=100)");
            else
            {
                deQuy(1, n);
                MessageBox.Show("Hoàn thành!");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        int dem = 1;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dem % 2 != 0)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
            dem = dem + 1;
        }

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }
    }
}
