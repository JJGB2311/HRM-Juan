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
        string IDemple;
        ModeloEmpleado logic = new ModeloEmpleado();
        public Datalleconceptos(string user,string emple)
        {
            InitializeComponent();
            user = usuario;
            LblUsuario.Text = usuario;
            Mostrarcon(emple);
        }
        void Mostrarcon(string emple)
        {
            DataTable dt = logic.consultaLogicacon(emple);
            dataGridView1.DataSource = dt;
        }
        private void Datalleconceptos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados nuevo = new Empleados(usuario);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
        }
    }
}
