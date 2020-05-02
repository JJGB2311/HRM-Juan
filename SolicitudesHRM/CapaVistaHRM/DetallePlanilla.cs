using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloHRM;
using System.Data.Odbc;

namespace CapaVistaHRM
{
    public partial class DetallePlanilla : Form
    {
        OdbcConnection cn = new OdbcConnection("Dsn=ERP");
        Modeloplanilla logic = new Modeloplanilla();
        string tabla = "def";
        string user;
        string fechai;
        string fecha;
      
        string dato;
        string fechain;
        string fechafi;
        public DetallePlanilla(string usuario, string id, string fechai, string fechaf)
        {
            InitializeComponent();
            user = usuario;
            dato = id;
            fechain = fechai;
            fechafi = fechaf;
            LblUsuario.Text = usuario;
            Lbl_planinlla.Text = dato;
            Lbl_fechai.Text = fechain;
            Lbl_fechaf.Text = fechafi;
            Mostrarpla();
        }
        void Mostrarpla()
        {
           
            DataTable dt = logic.consultaLogicadet(tabla);
            dataGridView1.DataSource = dt;
        }

        
        private void DetallePlanilla_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
