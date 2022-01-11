using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDNP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt1.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
            }
            else
            {
                if (rdo2.Checked == true && rdo3.Checked == true)
                    MessageBox.Show("Vui lòng chọn lại!");

                if (rdo1.Checked == true && rdo4.Checked == true)
                    MessageBox.Show("Vui lòng chọn lại!");

                if (rdo5.Checked == true && rdo6.Checked == true)
                    MessageBox.Show("Vui lòng chọn lại!");

                // thap phan sang nhị phân
                if (rdo1.Checked == true && rdo3.Checked == true)
                {
                    int tp = Convert.ToInt32(txt1.Text);
                    txt2.Text = "";
                    if (tp == 0)
                        txt2.Text = "0";
                    else
                    {
                        while (tp >= 1)
                        {
                            int du1 = tp % 2;
                            txt2.Text = Convert.ToString(du1) + txt2.Text;
                            tp = tp / 2;
                        }
                    }
                }

                //nhị phân sang thập phân
                double dec = 0;
                int i = 0;
                if (rdo2.Checked == true && rdo4.Checked == true)
                {
                    int np = Convert.ToInt32(txt1.Text);
                    while (np >= 1)
                    {
                        int du2 = np % 10;
                        dec = dec + du2 * Math.Pow(2, i);
                        i++;
                        np = np / 10;
                    }
                    txt2.Text = Convert.ToString(dec);
                }

                //thap phan sang thap luc phan
                if (rdo1.Checked == true && rdo6.Checked == true)
                {
                    txt2.Text = "";
                    int decn, q, dn = 0, m, l;
                    int tmp;
                    int s;
                    decn = Convert.ToInt32(txt1.Text);
                    q = decn;
                    for (l = q; l > 0; l = l / 16)
                    {
                        tmp = l % 16;
                        if (tmp < 10)
                            tmp = tmp + 48;
                        else
                            tmp = tmp + 55;
                        dn = dn * 100 + tmp;
                    }

                    //so tuong duong la
                    for (m = dn; m > 0; m = m / 100)
                    {
                        s = m % 100;
                        txt2.Text = txt2.Text + Convert.ToString((char)s);
                    }
                }

                //thap luc phan sang thap phan
                if (rdo5.Checked == true && rdo4.Checked == true)
                {
                    txt2.Text = "";
                    string hexValue = Convert.ToString(txt1.Text);
                    int decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                    txt2.Text = Convert.ToString(decValue);
                }

                //chuyen nhi phan sang thap luc phan
                if (rdo2.Checked == true && rdo6.Checked == true)
                {
                    txt2.Text = "";
                    string strBinary = Convert.ToString(txt1.Text);
                    string strHex = Convert.ToInt32(strBinary, 2).ToString("X");
                    txt2.Text = Convert.ToString(strHex);
                }

                //chuuyen thap luc phan sang nhi phan
                if (rdo5.Checked == true && rdo3.Checked == true)
                {
                    txt2.Text = "";
                    string strHex = Convert.ToString(txt1.Text);
                    string strBinary = Convert.ToString(Convert.ToInt32(strHex, 16), 2);
                    txt2.Text = Convert.ToString(strBinary);
                }
            }
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
