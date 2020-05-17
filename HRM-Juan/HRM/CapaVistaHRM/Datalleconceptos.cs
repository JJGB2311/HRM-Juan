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
    public partial class Datalleconceptos : Form
    {
        string usuario = "";
        ModeloEmpleado logic = new ModeloEmpleado();
        public Datalleconceptos(string user,string emple)
        {
            InitializeComponent();
            usuario = user;
            LblUsuario.Text = usuario;
            Mostrarcon(emple);
            ProgressBar1.Value = 100;
        }
        void Mostrarcon(string emple)
        {
            DataTable dt = logic.consultaLogicacon(emple);
            dataGridView1.DataSource = dt;
        }
        private void Datalleconceptos_Load(object sender, EventArgs e)
        {
            progres();
        }
        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            progres();
            Empleados nuevo = new Empleados(usuario);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
        }
    }
}
