using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaModeloHRM;
using CapaVista;
namespace CapaVistaHRM
{
    public partial class Mantenifini : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        public Mantenifini()
        {
            InitializeComponent();
            Mostrardes();
        }
        void Mostrardes()
        {
            DataTable dt = logic.consultaLogicades();
            dataGridView1.DataSource = dt;
        }
        private void Mantenifini_Load(object sender, EventArgs e)
        {

        }
    }
}
