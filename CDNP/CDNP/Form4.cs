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
    public partial class Form4 : Form
    {
        public Form4()
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

        string daoNguoc(string s)
        {
            string dao = "";
            int l = s.Length;
            for (int i = l - 1; i >= 0; --i)
                dao = dao + s[i];
            return dao;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lbl1.Text);
            rtxt1.Text = "";
            if (Convert.ToInt32(n) > 100 || Convert.ToInt32(n) <= 0)
                MessageBox.Show("Chú ý nhập lại n (3<n<=100)");
            else
            {
                if (n <= 3)
                    MessageBox.Show("Độ dài n không đủ thực hiện bài toán, Nhập lại n!");
                else
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = i + 2; j < n - 1; j++)
                        {
                            string h = "";
                            for (int k = 0; k < n; k++)
                            {
                                if (k == i || k == j)
                                    h = h + "1";
                                else
                                    h = h + "0";
                            }
                            h = daoNguoc(h);
                            StreamWriter ghi = new StreamWriter("out3.txt", true);
                            ghi.WriteLine(h);
                            ghi.Close();
                            rtxt1.Text = rtxt1.Text + Convert.ToString(h) + " ";
                        }
                    }

                    if (n > 4)
                        for (int i = 0; i < n - 1; i++)
                        {
                            for (int j = i + 2; j < n - 1; j++)
                            {
                                string s = "";
                                for (int k = 0; k < n; k++)
                                {
                                    if (k == i || k == j)
                                        s = s + "0";
                                    else
                                        s = s + "1";
                                }
                                StreamWriter ghi = new StreamWriter("out3.txt", true);
                                ghi.WriteLine(s);
                                ghi.Close();
                                rtxt1.Text = rtxt1.Text + Convert.ToString(s) + " ";
                            }
                        }
                    MessageBox.Show("Hoàn thành!");
                }
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
