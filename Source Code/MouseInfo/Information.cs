using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp_Spammer;

namespace MouseInfo
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Copy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Donate donate = new Donate();
            donate.Show();
        }
    }
}
