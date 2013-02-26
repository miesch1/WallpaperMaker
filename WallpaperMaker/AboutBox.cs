using System;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsApplication1
{
	public partial class AboutBox : Form
	{
		public AboutBox()
		{
			InitializeComponent();

			// Get the executing Assembly.
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			mVersionLabel.Text = executingAssembly.GetName().Version.ToString();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
