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
    public partial class Empleados : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        string emple;
        string vacio = "";
        string puesto;
        string area;
        public Empleados(string user)
        {
            InitializeComponent();
            Mostraremp();
            usuario = user;
            LblUsuario.Text = usuario;
            DTP_fechana.CustomFormat = "yyyy-MM-dd";
            DTP_fechana.Format = DateTimePickerFormat.Custom;
            Cbo_sexo.Items.Add("Masculino");
            Cbo_sexo.Items.Add("Femenino");
            combo1.llenarse("puestos", "id_puesto","nombre");
            combo2.llenarse("area", "id_area", "nombre");

        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica();
            dataGridView1.DataSource = dt;
        }
      
       
         string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE empleados set estado = 0 WHERE id_empleado =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            return query;
        }

        string crearUpdate()// crea el query de update
        {
			string query = "UPDATE `empleados` SET `nombre` = '"+Txt_nombre.Text+"', `apellido` = '"+Txt_apellido.Text+"', `sexo` = '"+Cbo_sexo.Text+"', `fecha_de_nacimiento` = '"+DTP_fechana.Text+"', `cui` = '"+Txt_cui.Text+"', `correo` = '"+Txt_correo.Text+"', `id_puesto` = '"+ combo1.ObtenerIndif()+ "', `id_area` = '" + combo2.ObtenerIndif() + "', `nit` = '" + Txt_nit.Text+"', `direccion` = '"+Txt_direccion.Text+"' WHERE `empleados`.`id_empleado` =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
			

			return query;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         Datalleconceptos nuevo = new Datalleconceptos (usuario, emple);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
        }

       

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txt_apellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Cbo_sexo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                DTP_fechana.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Txt_cui.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Txt_correo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               puesto = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                area = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Txt_nit.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                Txt_direccion.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                emple = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                combo1.texto(puesto);
                combo2.texto(area);
                Btn_concep.Enabled = true;
                Btn_elimi.Enabled = true;
                Btn_Modi.Enabled = true;
                Txt_nombre.Enabled = true;
                Txt_apellido.Enabled = true;
                Txt_apellido.Enabled = true;
                Cbo_sexo.Enabled = true;
                Txt_cui.Enabled = true;
                Txt_nit.Enabled = true;
                DTP_fechana.Enabled = true;
                Txt_correo.Enabled = true;
                combo1.Enabled = true;
                combo2.Enabled = true;
                Txt_direccion.Enabled = true;
                progres();

            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearUpdate());
            Mostraremp();
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            Txt_id.Text = "";
            Txt_nit.Text = "";
            Txt_direccion.Text = "";
            Txt_cui.Text = "";
            Txt_correo.Text = "";
            Cbo_sexo.Text = "";
            Btn_concep.Enabled = false;
            Btn_elimi.Enabled = false;
            Btn_Modi.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_apellido.Enabled = false;
            Txt_apellido.Enabled = false;
            Cbo_sexo.Enabled = false;
            Txt_cui.Enabled = false;
            Txt_nit.Enabled = false;
            DTP_fechana.Enabled = false;
            Txt_correo.Enabled = false;
            combo1.Enabled = false;
            combo2.Enabled = false;
            Txt_direccion.Enabled = false;
            combo1.texto(vacio);
            combo2.texto(vacio);
            progres();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearDelete());
            Mostraremp();
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            Txt_id.Text = "";
            Txt_nit.Text = "";
            Txt_direccion.Text = "";
            Txt_cui.Text = "";
            Txt_correo.Text = "";
            Btn_concep.Enabled = false;
            Btn_elimi.Enabled = false;
            Btn_Modi.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_apellido.Enabled = false;
            Txt_apellido.Enabled = false;
            Cbo_sexo.Enabled = false;
            Txt_cui.Enabled = false;
            Txt_nit.Enabled = false;
            DTP_fechana.Enabled = false;
            Txt_correo.Enabled = false;
            combo1.Enabled = false;
            combo2.Enabled = false;
            Txt_direccion.Enabled = false;
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
        private void Empleados_Load(object sender, EventArgs e)
        {
            progres();
        }
        /*Validaciones*/
        public void letra(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void numero(KeyPressEventArgs e)
        {
            char dosp = (char)58;
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == dosp)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("En ese campo solo puede ingresar numeros");
            }
        }
        public void letrasimbolo(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("En ese campo solo puede ingresar letras y simbolos");
            }
        }
        public void numerosimbolo(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

  
        public void letracombo(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        /********/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cbo_sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            letracombo(e);
        }

        private void ayudaRup1_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "mempleados.html");
        }
    }
}
