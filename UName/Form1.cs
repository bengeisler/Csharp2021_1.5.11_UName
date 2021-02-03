using System;
using System.Drawing;
using System.Windows.Forms;

namespace UName
{
	public partial class frmMeinName : Form
	{
		public frmMeinName()
		{
			InitializeComponent();
		}

		private void btnMeinName_Click(object sender, EventArgs e)
		{
			lblMeinName.Text = "Benedikt Geisler";
		}

		private void btnEnde_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnGrößeÄndern_Click(object sender, EventArgs e)
		{
			btnMeinName.Size = new Size(
				btnMeinName.Size.Width + 10,
				btnMeinName.Size.Height + 10);
		}

		private void btnHoch_Click(object sender, EventArgs e)
		{
			btnMeinName.Location = new Point(
				btnMeinName.Location.X,
				btnMeinName.Location.Y - 10);
		}

		private void btnRunter_Click(object sender, EventArgs e)
		{
			btnMeinName.Location = new Point(
				btnMeinName.Location.X,
				btnMeinName.Location.Y + 10);
		}

		private void btnMeineInformationen_Click(object sender, EventArgs e)
		{
			// Ausgabe: Name, Alter: .., Wohnort: 
			// => lblMeinName
			lblMeinName.Text =
				"Benedikt Geisler \n"
				+ "Alter: " + 30 + "\n"
				+ "Wohnort: Regensburg";
		}

		private void btnFarbeÄndern_Click(object sender, EventArgs e)
		{
			btnMeinName.BackColor = Color.Green;
		}
	}
}
