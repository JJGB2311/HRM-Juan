using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFHelpViewer
{
	public partial class AyudaRup : UserControl
	{
		string doc = "";
		public AyudaRup()
		{
			InitializeComponent();
		}
		public void AsignarAyuda(string ruta) {
			doc = ruta;
		}
		private void PictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = global::PDFHelpViewer.Properties.Resources.round__3_;
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
			PDFHelpViewer ayuda = new PDFHelpViewer(doc);
			ayuda.Show();
		}

		private void PictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = global::PDFHelpViewer.Properties.Resources.round;
		}
	}
}
