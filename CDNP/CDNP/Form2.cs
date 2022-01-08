﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string daoNguoc(string s)
        {
            string dao = "";
            int l = s.Length;
            for (int i = l - 1; i >= 0; --i)
                dao = dao + s[i];
            return dao;
        }

        string xoaKyTuCuoi(string s)
        {
            string r = "";
            for (int i = 0; i < s.Length - 1; ++i)
                r += s[i];
            return r;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl3.Text = "";
            if (String.IsNullOrEmpty(txt1.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
            }
            else
            {
                int tp = Convert.ToInt32(txt1.Text);
                for (ulong i = 0; i < Math.Pow(2, tp); i++)
                {
                    ulong x = i;
                    string s = "";
                    while (x != 0)
                    {
                        if (x % 2 == 1)
                            s = s + "1";
                        else
                            s = s + "0";
                        x /= 2;
                    }

                    if (s == "")
                        s = "0";
                    else
                        for (int j = s.Length - 1; j > 0; --j)
                        {
                            if (s[j] == '1' || s.Length == 1)
                                break;
                            else
                                s = xoaKyTuCuoi(s);
                        }
                    s = daoNguoc(s) + " ";
                    StreamWriter ghi = new StreamWriter("out1.txt", true);
                    ghi.WriteLine(s);
                    ghi.Close();
                    lbl3.Text = lbl3.Text + Convert.ToString(s) + " ";
                }
                MessageBox.Show("Hoàn thành!");
            }
                
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            lbl3.Text = "";
        }
    }
}