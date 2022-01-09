using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CDNP
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            pic1.Hide();
            pic2.Hide();
            pic3.Hide();
            pic4.Hide();
            pic5.Hide();
            pic6.Hide();
            pic7.Hide();
            pic8.Hide();
            pic9.Hide();
            pic10.Hide();
            pic11.Hide();
            pic12.Hide();
            label5.Hide();
            label4.Hide();
            label6.Hide();
            lbl4.Hide();
            lbl5.Hide();
        }

        public void anpic()
        {
            pic1.Hide();
            pic2.Hide();
            pic3.Hide();
            pic4.Hide();
            pic5.Hide();
            pic6.Hide();
            pic7.Hide();
            pic8.Hide();
            pic9.Hide();
            pic10.Hide();
            pic11.Hide();
            pic12.Hide();
            label5.Hide();
            label4.Hide();
            label6.Hide();
            lbl4.Hide();
            lbl5.Hide();
        }

        int[] Arr;
        Button[] BArr;
        const int GAP = 50;
        const int HEIGHT = 100;
        const int SIZE = 50;

        private void dichuyen(int i)
        {
            Status st = new Status();
            st.Pos1 = i;
            // st.Pos2 = j;
            st.type = MoveType.MOVE_TOP_DOWN;
            for (int x = 0; x < SIZE; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_LEFT_RiGHT;
            // int Distance = Math.Abs(i - j) * (SIZE + GAP);
            // for (int x = 0; x < Distance; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_IN_LINE;
            for (int x = 0; x < SIZE; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVED;
            backgroundWorker1.ReportProgress(0, st);
            System.Threading.Thread.Sleep(10);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
         
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;
            if (st == null) return;
            if (st.type == MoveType.MOVED)
            {
                Button tmp = BArr[st.Pos1];
                BArr[st.Pos1] = BArr[st.Pos2];
                BArr[st.Pos2] = tmp;
                return;
            }
            Button btn1 = BArr[st.Pos1];
            Button btn2 = BArr[st.Pos2];
            if (st.type == MoveType.MOVE_TOP_DOWN)
            {
                btn1.Top = btn1.Top + 1;
                btn2.Top = btn2.Top - 1;
            }
            else if (st.type == MoveType.MOVE_LEFT_RiGHT)
            {
                btn1.Left = btn1.Left - 1;
                btn2.Left = btn2.Left + 1;
            }
            else if (st.type == MoveType.MOVE_IN_LINE)
            {
                btn1.Top = btn1.Top - 1;
                btn2.Top = btn2.Top + 1;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button btn in panel1.Controls)
            {
                btn.BackColor = Color.ForestGreen;
                btn.ForeColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            anpic();
            int tam = 0;
            if (String.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Không được bỏ trống n!");
            else
            {

                int k = Convert.ToInt32(textBox1.Text);
                if (Convert.ToInt32(k) <= 0 || Convert.ToInt32(k) > 63)
                {
                    MessageBox.Show("Vui lòng nhập lại n (0<n<63)!");
                }
                else
                {
                    label5.Show();
                    label4.Show();
                    int n = int.Parse(textBox1.Text);
                    Arr = new int[n];
                    BArr = new Button[n];
                    panel1.Controls.Clear();
                    panel2.Controls.Clear();
                    lbl4.Text = "";
                    lbl5.Text = "";

                    while (n != 0)
                    {
                        int i = 0;
                        Button btn = new Button();
                        Button btn2 = new Button();
                        int val = n;
                        int sodu = n % 2;

                        btn.Text = val.ToString();
                        btn.Width = btn.Height = SIZE;
                        btn.Location = new Point(panel1.Controls.Count * (btn.Width + GAP), panel1.Height / 2 - btn.Height);

                        btn2.Text = sodu.ToString();
                        btn2.Width = btn2.Height = SIZE;
                        btn2.Location = new Point(panel2.Controls.Count * (btn.Width + GAP), panel2.Height / 2 - btn.Height);

                        Arr[i] = val;
                        BArr[i] = btn;
                        panel1.Controls.Add(btn);

                        Arr[i] = sodu;
                        BArr[i] = btn2;
                        panel2.Controls.Add(btn2);

                        lbl4.Text = Convert.ToString(sodu) + lbl4.Text;

                        btn2.BackColor = Color.ForestGreen;
                        btn2.ForeColor = Color.White;

                        n /= 2;
                        i = i + 1;

                        tam = tam + 1;
                    }
                    lbl5.Text = "Kết Quả";

                    if (tam == 1)
                    {
                        await Task.Delay(2000);
                        pic6.Show();
                        await Task.Delay(1000);
                    }

                    if (tam == 2)
                    {
                        await Task.Delay(1000);
                        pic1.Show();
                        await Task.Delay(1000);
                        pic6.Show();
                        await Task.Delay(2000);
                        pic7.Show();
                        await Task.Delay(1000);
                    }

                    if (tam == 3)
                    {
                        await Task.Delay(1000);
                        pic1.Show();
                        await Task.Delay(1000);
                        pic6.Show();
                        await Task.Delay(1000);
                        pic2.Show();
                        await Task.Delay(1000);
                        pic7.Show();
                        await Task.Delay(2000);
                        pic8.Show();
                        await Task.Delay(1000);
                    }

                    if (tam == 4)
                    {
                        await Task.Delay(1000);
                        pic1.Show();
                        await Task.Delay(1000);
                        pic6.Show();
                        await Task.Delay(1000);
                        pic2.Show();
                        await Task.Delay(1000);
                        pic7.Show();
                        await Task.Delay(1000);
                        pic3.Show();
                        await Task.Delay(1000);
                        pic8.Show();
                        await Task.Delay(2000);
                        pic9.Show();
                        await Task.Delay(1000);
                    }

                    if (tam == 5)
                    {
                        await Task.Delay(1000);
                        pic1.Show();
                        await Task.Delay(1000);
                        pic6.Show();
                        await Task.Delay(1000);
                        pic2.Show();
                        await Task.Delay(1000);
                        pic7.Show();
                        await Task.Delay(1000);
                        pic3.Show();
                        await Task.Delay(1000);
                        pic8.Show();
                        await Task.Delay(1000);
                        pic4.Show();
                        await Task.Delay(1000);
                        pic9.Show();
                        await Task.Delay(2000);
                        pic10.Show();
                        await Task.Delay(1000);
                    }

                    if (tam == 6)
                    {
                        await Task.Delay(1000);
                        pic1.Show();
                        await Task.Delay(1000);
                        pic6.Show();
                        await Task.Delay(1000);
                        pic2.Show();
                        await Task.Delay(1000);
                        pic7.Show();
                        await Task.Delay(1000);
                        pic3.Show();
                        await Task.Delay(1000);
                        pic8.Show();
                        await Task.Delay(1000);
                        pic4.Show();
                        await Task.Delay(1000);
                        pic9.Show();
                        await Task.Delay(1000);
                        pic5.Show();
                        await Task.Delay(1000);
                        pic10.Show();
                        await Task.Delay(2000);
                        pic11.Show();
                        await Task.Delay(1000);
                    }

                    pic12.Show();
                    label6.Show();
                    await Task.Delay(1000);

                    lbl4.Show();
                    lbl5.Show();
                    await Task.Delay(1000);
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
