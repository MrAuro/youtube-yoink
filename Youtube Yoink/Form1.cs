using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Yoink
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String url = textBox1.Text;

			if (radioButton1.Checked)
			{
				System.Diagnostics.Process.Start("ytdl.exe", "-x --audio-format mp3 " + url);

			}
			else if (radioButton2.Checked)
			{
				System.Diagnostics.Process.Start("ytdl.exe", "-f 'bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4'" + url);

			}
			else if (radioButton3.Checked)
			{
				System.Diagnostics.Process.Start("ytdl.exe", "-x --audio-format wav " + url);
			}
			else
			{
				throw new Exception("No radio button selected");
			}

		}
	}
}
