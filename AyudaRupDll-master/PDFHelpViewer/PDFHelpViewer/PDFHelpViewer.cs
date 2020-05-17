using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFHelpViewer
{
	public partial class PDFHelpViewer : Form
	{
		public PDFHelpViewer(string PDF)
		{
			InitializeComponent();
			axAcroPDF1.src = PDF;
		}

		private void PDFHelpViewer_Load(object sender, EventArgs e)
		{

		}
	}
}
