using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaHRM
{
    public partial class Conceptos : Form
    {
        string usuario;
        public Conceptos(string user)
        {
            InitializeComponent();
            user = usuario;
            LblUsuario.Text = usuario;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Conceptos_Load(object sender, EventArgs e)
        {

        }
    }
}
