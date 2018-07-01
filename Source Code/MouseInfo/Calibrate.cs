using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseInfo
{
	public partial class Calibrate : Form
	{
		public Calibrate()
		{
			InitializeComponent();
		}
		int MousePosX;
		bool calibrating = false;
		int CalDST;


		private void button1_Click(object sender, EventArgs e)
		{
			MousePosX = MousePosition.X;
			calibrating = true;
		}

		private void Calibrate_Load(object sender, EventArgs e)
		{

		}

		private void Calibrate_Click(object sender, EventArgs e)
		{
			if (calibrating)
			{
				CalDST = MousePosition.X - MousePosX;
				Info.divisor = CalDST;
				Properties.Settings.Default.Divisor = CalDST;
				calibrating = false;
				Properties.Settings.Default.Calibrated = true;
				
				Properties.Settings.Default.Save();

				this.Close();
			}
		}
	}
}
