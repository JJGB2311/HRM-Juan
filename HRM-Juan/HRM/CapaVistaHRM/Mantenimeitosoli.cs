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
    public partial class Mantenimeitosoli : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        public Mantenimeitosoli(string user)
        {
            InitializeComponent();
            Mostraremp();
        }
       /* string crearInsert()// crea el query de insert
        {
           // string query = "INSERT INTO `solicitudes` (`id_solicitud`, `id_perfil`, `id_area`, `fecha`, `detalles`, `Cantidad`, `motivo`, `id_puesto`, `porcentaje`, `estado`) VALUES (NULL, '" + combo1.ObtenerIndif() + "', '" + combo2.ObtenerIndif() + "', '" + DTP_fecha.Text + "', '" + txt_detalle.Text + "', '" + txt_cantidad.Text + "', '" + txt_motivo.Text + "', '" + combo3.ObtenerIndif() + "', '10', '1');";

         //   return query;
        }*/
        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
            }

        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogisoli();
            dataGridView1.DataSource = dt;
        }
        private void Mantenimeitosoli_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
