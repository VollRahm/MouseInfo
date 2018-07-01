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
using MouseKeyboardLibrary;
using Microsoft.Win32;



namespace MouseInfo
{
    public partial class Info : Form
    {  
		
		MouseHook mouse = new MouseHook();
		int lClicks;
		int rClicks;
		int MidClicks;
		public static int cpsLeft;
		CPSOverlay overlay = new CPSOverlay();
		//
		// VARIABLES FOR DISTANCE
		int Xbefore = 0;
		int Ybefore = 0;
		double tempDistance;
		bool scanned = false;

		public static int divisor = 275;
		double dstInMeters;


		public Info()
        {
			
            InitializeComponent();
            this.ControlBox = false;
			checkForCal.Enabled = true;
           
			positionTimer.Enabled = true;
			cpsTimer.Enabled = true;
			GetConfig();
			this.MaximumSize = this.Size;
			autostart.Checked = Properties.Settings.Default.Autostart;
			mouse.MouseUp += new MouseEventHandler(OnMouseClick);
			mouse.MouseWheel += new MouseEventHandler(OnMouseClick);
			
			mouse.Start();

		}

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.Hide();
			SystemTray.ShowBalloonTip(1000, "MouseInfo", "The App was minimized to System Tray", ToolTipIcon.Info);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			mouse.Stop();
            Application.Exit();
        }
		
        private void reset_Click(object sender, EventArgs e)
        {
			Properties.Settings.Default.LeftClicks = 0;
			Properties.Settings.Default.MouseWheel = 0;
			Properties.Settings.Default.RightClicks = 0;
			Properties.Settings.Default.Distance = 0;
			Properties.Settings.Default.Save();
			lClicks = 0;
			rClicks = 0;
			MidClicks = 0;
			lClick.Text = "Left Klicks: " + lClicks;
			rClick.Text = "Right Klicks: " + rClicks;
			MouseWheel.Text = "Mouse Wheel Ticks: " + MidClicks;
			tempDistance = 0;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
        }

		private void positionTimer_Tick(object sender, EventArgs e)
		{
			positionText.Text = "Postion: X = " + MousePosition.X + " Y = " + MousePosition.Y;
		}

		private void donateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Donate donate = new Donate();
			donate.Show();
		}

		private void OnMouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				lClicks++;
				cpsLeft++;
				lClick.Text = "Left Klicks: " + lClicks;
				Properties.Settings.Default.LeftClicks = lClicks;
				Properties.Settings.Default.Save();
				

			}
			else if (e.Button == MouseButtons.Right)
			{
				rClicks++;
				
				rClick.Text = "Right Klicks: " + rClicks;
				Properties.Settings.Default.RightClicks = rClicks;
				Properties.Settings.Default.Save();
			}
			else
			{
				if (e.Delta < 0)
				{
					MidClicks += -e.Delta/120;
				}
				else {
					MidClicks += e.Delta / 120;
				}
				MouseWheel.Text = "Mouse Wheel Ticks: " + MidClicks;
				Properties.Settings.Default.MouseWheel = MidClicks;
				Properties.Settings.Default.Save();
			}
		}

		private void GetConfig()
		{
			lClicks = Properties.Settings.Default.LeftClicks;
			rClicks = Properties.Settings.Default.RightClicks;
			MidClicks = Properties.Settings.Default.MouseWheel;
			lClick.Text = "Left Klicks: " + lClicks;
			rClick.Text = "Right Klicks: " + rClicks;
			MouseWheel.Text = "Mouse Wheel Ticks: " + MidClicks;
			distanceLbl.Text = "Distance: " + Properties.Settings.Default.Distance + " meter";
			overlaySwitch.Checked = Properties.Settings.Default.CPSOverlay;
			autostart.Checked = Properties.Settings.Default.Autostart;
			tempDistance = Properties.Settings.Default.Distance;
			divisor = Properties.Settings.Default.Divisor;
		}

		private void autostart_CheckedChanged(object sender, EventArgs e)
		{
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);


			if (autostart.Checked)
			{
				rk.SetValue("MouseInfo", Application.ExecutablePath);
				Properties.Settings.Default.Autostart = autostart.Checked;
			}
			else
			{
				rk.DeleteValue("MouseInfo", false);
				Properties.Settings.Default.Autostart = autostart.Checked;
			}
			Properties.Settings.Default.Save();
		}

		private void cpsTimer_Tick(object sender, EventArgs e)
		{
			cpsLabel.Text ="CPS: " + cpsLeft.ToString();
		
			cpsLeft = 0;
			
		}

		private void overlaySwitch_CheckedChanged(object sender, EventArgs e)
		{
			if (overlaySwitch.Checked)
			{
				overlay.Show();
				Properties.Settings.Default.CPSOverlay = overlaySwitch.Checked;
			}
			else
			{
				overlay.Hide();
				Properties.Settings.Default.CPSOverlay = overlaySwitch.Checked;
			}
			Properties.Settings.Default.Save();
		}
						
		private double CalcDistance(double x1, double y1, double x2, double y2)
		{
			var temp1 = Math.Pow((x2 - x1), 2);
			var temp2 = Math.Pow((y2 - y1), 2);
			var result = Math.Sqrt(temp1 + temp2);
			return result;
		}
				
		private void DistanceTimer_Tick_1(object sender, EventArgs e)
		{
			if (!scanned)
			{
				Xbefore = MousePosition.X;
				Ybefore = MousePosition.Y;
				scanned = true;
			}
			else
			{
				tempDistance += Math.Round(CalcDistance(Xbefore, Ybefore, MousePosition.X, MousePosition.Y))/divisor;
				
				Xbefore = MousePosition.X;
				Ybefore = MousePosition.Y;
				dstInMeters = Math.Round(tempDistance / 100,2);

				distanceLbl.Text = "Distance: " + dstInMeters + " meter";
				//Properties.Settings.Default.Distance = tempDistance;
				//Properties.Settings.Default.Save();
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Calibrate calibrate = new Calibrate();
			calibrate.Show();
		}

		private void checkForCal_Tick(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.Calibrated) this.pictureBox1.Visible = false;
			else this.pictureBox1.Visible = true;
		}

	
	}
}
