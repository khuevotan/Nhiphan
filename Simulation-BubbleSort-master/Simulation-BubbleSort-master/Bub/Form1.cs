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


namespace Bub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        int[] Arr;
        Button[] BArr;
        const int GAP = 50;
        const int HEIGHT = 100;
        const int SIZE = 50;

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Arr = new int[n];
            BArr = new Button[n];
            panel1.Controls.Clear();
            panel2.Controls.Clear();

            while (n != 0)
            {
                int i = 0;
                Button btn = new Button();
                Button btn2 = new Button();
                int val = n;
                int sodu = n%2;

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
             
                btn2.BackColor = Color.ForestGreen;
                btn2.ForeColor = Color.White;
        
                n /= 2;
                i = i + 1;
               // Thread.Sleep(1000);
            }
        }
        public void BubbleSort(int[] arr)
        {
            int i, j;
          
                       // MoveButton(j, j-1);
        }

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


        private void MoveButton(int i, int j)
        {
            Status st = new Status();
            st.Pos1 = i;
            st.Pos2 = j;
            st.type = MoveType.MOVE_TOP_DOWN;
            for(int x =0; x < SIZE; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_LEFT_RiGHT;
            int Distance = Math.Abs(i - j) * (SIZE + GAP);
            for(int x = 0; x < Distance; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_IN_LINE;
            for(int x = 0; x < SIZE; x++)
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
            BubbleSort(Arr);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;
            if (st == null) return;
            if(st.type == MoveType.MOVED)
            {
                Button tmp = BArr[st.Pos1];
                BArr[st.Pos1] = BArr[st.Pos2];
                BArr[st.Pos2] = tmp;
                return;
            }
            Button btn1 = BArr[st.Pos1];
            Button btn2 = BArr[st.Pos2];
            if(st.type == MoveType.MOVE_TOP_DOWN)
            {
                btn1.Top = btn1.Top + 1;
                btn2.Top = btn2.Top - 1;
            }
            else if(st.type == MoveType.MOVE_LEFT_RiGHT)
            {
                btn1.Left = btn1.Left - 1;
                btn2.Left = btn2.Left + 1;
            }
            else if(st.type == MoveType.MOVE_IN_LINE)
            {
                btn1.Top = btn1.Top - 1;
                btn2.Top = btn2.Top + 1;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(Button btn in panel1.Controls)
            {
                btn.BackColor = Color.ForestGreen;
                btn.ForeColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
