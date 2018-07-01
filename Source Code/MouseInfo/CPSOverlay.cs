using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseInfo
{
	public partial class CPSOverlay : Form
	{

		[DllImport("user32.dll", EntryPoint = "SetWindowLongW")]
		private static extern IntPtr SetWindowLongPtr32(IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
		static extern int GetWindowLongPtr( IntPtr hWnd, int nIndex);

		
		public CPSOverlay()
		{
			InitializeComponent();
		}

		private void CPSOverlay_Load(object sender, EventArgs e)
		{
			this.BackColor = Color.Black;
			this.TransparencyKey = Color.Black;
			int initialStyle = GetWindowLongPtr(this.Handle, -20);
			SetWindowLongPtr32(this.Handle, -20, initialStyle | 0x80000 | 0x20);
			
		}

		private void Updater_Tick(object sender, EventArgs e)
		{
			label1.Text = Info.cpsLeft.ToString();
		}
	}
}
