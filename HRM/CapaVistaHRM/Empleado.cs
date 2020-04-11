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
    public partial class Empleado : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        Modeloplani logic = new Modeloplani();
        string tabla = "def";
        public Empleado()
        {
            InitializeComponent();
            // llenartabla();
            prueba();
        }
        void llenartabla()
        {
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;

            codigo.CommandText = ("SELECT * FROM `empleados` WHERE 1");
            try
            {
                OdbcDataAdapter ejecutar = new OdbcDataAdapter();
                ejecutar.SelectCommand = codigo;
                DataTable datostabla = new DataTable();
                ejecutar.Fill(datostabla);
                dataGridView1.DataSource = datostabla;
                ejecutar.Update(datostabla);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }


        void prueba() {
            DataTable dt = logic.consultaLogica(tabla);
            dataGridView1.DataSource = dt;
        }

            private void Empleadocs_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
