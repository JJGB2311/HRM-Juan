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
   
    public partial class Finiquitos : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        string ID;
        public Finiquitos(string user, string id)
        {
            InitializeComponent();
            usuario = user;
            ID = id;
            Txt_nombre.Text = ID;
            Mostraremp();
        }
        string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE empleados set estado = 2 WHERE id_empleado =" +ID+";";
            return query;
        }
        string crearInsert()// crea el query de insert
        {
            string query = "INSERT INTO `finiqito` (`id_finiqito`, `id_empleados`, `motivo`, `descripcion`, `total_prestaciones`, `estado`) VALUES (NULL, '"+ID+"', '"+Txt_motivo.Text+"', '"+Txt_descrip.Text+"', '"+Txt_prestaciones.Text+"', '1');";
            return query;
        }
        private void Finiquitos_Load(object sender, EventArgs e)
        {
            progres();
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogicafini();
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            logic.nuevoQuery(crearDelete());
            logic.nuevoQuery(crearInsert());
            Mostraremp();
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            Txt_descrip.Text = "";
            Txt_prestaciones.Text = "";
            Txt_motivo.Text = "";
            Txt_descrip.Text = "";
            btn_fin.Enabled = true;
            btn_gene.Enabled = false;
            MessageBox.Show("El proceso del despido Finalizo corectamente! Seleccione el boton siguiente para finalizar");
            progres();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "Generarfini.html");
        }
    }
}
