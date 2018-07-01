using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp_Spammer
{
    public partial class Donate : Form
    {

        string value = "1,00";

        public Donate()
        {
            InitializeComponent();
        }
       
        private void amount_ValueChanged(object sender, EventArgs e)
        {
            value = amount.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = value.Replace(",", ".");
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=vollrahm@gmail.com&item_name=Mouse%20Info&item_number=Thank%20you!&amount=" + value +  "&currency_code=EUR");
            this.Close();
        }
    }
}
