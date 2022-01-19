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

        // liệt kê dãy nhị phân độ dài n trong đó "01" xuất hiện đúng 2 lần
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
                    // tạo mảng n phần tử có giá trị false
                    bool[] x = new bool[n];

                    // tạo mảng n phần tử có giá trị 0
                    int[] y = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        x[i] = false;
                    }

                    // đánh dấu 2 vị trí được chọn để chứa 2 cặp "01" -- duyệt cặp 01
                    for (int i = 0; i < n - 1; i++)
                    {
                        x[i] = true;
                        x[i + 1] = true;
                        for (int j = i + 2; j < n - 1; j++)
                        {
                            x[j] = true;
                            x[j + 1] = true;

                            // sau khi chọn được 2 vị trí cho 2 cặp 01, thì
                            // điền các giá trị 01 vào các vị trí đó
                            // và điển giá trị 0 vào các vị trí còn lại
                            for (int p = 0; p < n; p++)
                            {
                                if (x[p] == true)
                                {
                                    y[p] = 0;
                                    y[p + 1] = 1;
                                    p++;
                                }
                                else
                                    y[p] = 0;
                            }

                            int q = 0;
                            do
                            {
                                // xuất output
                                int s;
                                string h = "";
                                for (int p = 0; p < n; p++)
                                {
                                    s = y[p];
                                    h = h + Convert.ToString(s);

                                    // in ra màn h
                                    rtxt1.Text = rtxt1.Text + Convert.ToString(s);
                                }

                                rtxt1.Text = rtxt1.Text + " ";
                                //file text
                                StreamWriter ghi = new StreamWriter("out3.txt", true);
                                ghi.WriteLine(h);
                                ghi.Close();

                                // duyệt từ trái sang phải, nếu vị trí đó khác 2 vị trí đã
                                // chọn và giá trị tại đó là 0 thì gán thành 1
                                while (q < n)
                                {
                                    if (x[q] == false && y[q] == 0)
                                    {
                                        y[q] = 1;
                                        break;
                                    }
                                    q++;
                                }

                            } while (q < n);

                            x[j] = false;
                            x[j + 1] = false;
                        }
                        x[i] = false;
                        x[i + 1] = false;
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
