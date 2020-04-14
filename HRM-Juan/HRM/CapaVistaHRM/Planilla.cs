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
    public partial class Planilla : Form
    {
        Modeloplanilla logic = new Modeloplanilla();
        string tabla = "def";
        string user;
        string fechana;
        public Planilla(string user)
        {
            InitializeComponent();
            Mostrarpla();
        }
        string crearInsert()// crea el query de insert
        {


            string query = "INSERT INTO `planilla` (`id_planilla`, `fecha`, `Nombre`, `estado`) VALUES (NULL, '"+ fechana + "', '"+Txt_nombre.Text+"', '1');";

            return query;

        }
        private void Planilla_Load(object sender, EventArgs e)
        {
            user = LblUsuario.Text;
        }
        void Mostrarpla()
        {
            DataTable dt = logic.consultaLogicaplani(tabla);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            logic.nuevoQueryplani(crearInsert());
            Mostrarpla();
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechana = "";

        }

        private void DTP_fecha_ValueChanged(object sender, EventArgs e)
        {
            fechana = DTP_fecha.Value.ToString("yyyy/MM/dd");
        }
    }
}
