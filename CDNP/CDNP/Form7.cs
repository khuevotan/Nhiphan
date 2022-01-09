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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            pic1.Hide();
            pic2.Hide();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            pic1.Show();
            await Task.Delay(2000);
            pic2.Show();
        }
    }
}
