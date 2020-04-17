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
        string fechana;
        string usuario;
        public Empleados(string user)
        {
            InitializeComponent();
            Mostraremp();
            user = usuario;
            LblUsuario.Text = usuario;
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica(tabla);
            DTP_fechai.DataSource = dt;
        }
        private void Empleados_Load(object sender, EventArgs e)
        {

        }
        string crearInsert()// crea el query de insert
        {


            string query = "INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `fecha_de_nacimiento`, `cui`, `correo`, `id_puesto`, `id_area`, `nit`, `direccion`, `estado`) VALUES (NULL, '"+Txt_nombre.Text+"', '"+Txt_apellido.Text+"', 'Masculino', '"+ fechana + "', '"+Txt_cui.Text+"', '"+Txt_correo.Text+"', '1', '1', '"+Txt_nit.Text+"', '"+Txt_direccion.Text+"', '1');";

            return query;

        }
       /*  string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE ayuda set estado = 0 " + " WHERE Id_ayuda =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            return query;
        }*/

       /* string crearUpdate()// crea el query de update
        {
			string query = "UPDATE ayuda SET Ruta = 'Página web ayuda/ayuda.chm.', indice = 'Menúboletos.html.' WHERE ayuda.Id_ayuda = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
			string query = "UPDATE ayuda SET Ruta = '" + txtruta.Text.Replace("\\", "/") + "', indice = '" + txtindice.Text + "' WHERE ayuda.Id_ayuda = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();


			return query;
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearInsert());
            Mostraremp();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conceptos nuevo = new Conceptos(usuario);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void Dtp_naci_ValueChanged(object sender, EventArgs e)
        {
            fechana = DTP_fecha.Value.ToString("yyyy/MM/dd");
        }
    }
}
