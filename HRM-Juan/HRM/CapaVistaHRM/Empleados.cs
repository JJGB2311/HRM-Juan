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


namespace CapaVistaHRM
{
    public partial class Empleados : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        ModeloEmpleado logic = new ModeloEmpleado();
        string tabla = "def";
        public Empleados()
        {
            InitializeComponent();
            prueba();
        }
        void prueba()
        {
            DataTable dt = logic.consultaLogica(tabla);
            dataGridView1.DataSource = dt;
        }
        private void Empleados_Load(object sender, EventArgs e)
        {

        }
    }
}
