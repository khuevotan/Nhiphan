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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text File|*.txt", Multiselect = false })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    using (StreamReader rd=new StreamReader(ofd.FileName))
                    {
                        richTextBox1.Text = await rd.ReadToEndAsync();
                    }
                }
            }
        }
    }
}
