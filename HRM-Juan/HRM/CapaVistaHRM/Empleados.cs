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
            Mostraremp();
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica(tabla);
            dataGridView1.DataSource = dt;
        }
        private void Empleados_Load(object sender, EventArgs e)
        {

        }
        string crearInsert()// crea el query de insert
        {


            string query = "INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `fecha_de_nacimiento`, `correo`, `id_puesto`, `id_area`, `estado`) VALUES (NULL, 'pedro', 'sanches', 'Masculino', '2020-04-16', 'juan@hotmail.com', '1', '1', '1')";

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
    }
}
