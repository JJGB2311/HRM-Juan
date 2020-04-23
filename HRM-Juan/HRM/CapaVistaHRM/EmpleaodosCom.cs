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
    public partial class Btn_agrecon : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string tabla = "def";
        string fechana;
        string usuario;
        string fechaini = "1111-11-11";
        string fechafin = "1111-11-11";
        string debehaber;
        public Btn_agrecon(string user)
        {
            InitializeComponent();
            Mostraremp();
            user = usuario;
            LblUsuario.Text = usuario;
            DTP_fechana.Format = DateTimePickerFormat.Custom;
            DTP_fechana.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            Cbo_sex.Items.Add("Masculino");
            Cbo_sex.Items.Add("Femenino");
            combo1.llenarse("puestos", "id_puesto", "nombre");
            combo2.llenarse("area", "id_area", "nombre");
            combo3.llenarse("tipo_concepto", "id_tipo", "nombre");
            Btn_new.Enabled = true;
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica();
            dataGridView1.DataSource = dt;
        }
        void Mostrarcon(string emple)
        {
            DataTable dt = logic.consultaLogicacon(emple);
            dataGridView2.DataSource = dt;
        }
        string crearInsert()// crea el query de insert
        {
           string query = "INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `fecha_de_nacimiento`, `cui`, `correo`, `id_puesto`, `id_area`, `nit`, `direccion`, `estado`) VALUES (NULL, '" + Txt_nombre.Text + "', '"+Txt_apellido.Text+"', '"+Cbo_sex.Text+"', '"+ DTP_fechana.Text+ "', '"+Txt_cui.Text+"', '"+txt_correo.Text+"', '"+combo1.obtener()+ "', '" + combo2.obtener() + "', '" + Txt_nit.Text+"', '"+Txt_dire.Text+"', '1');";
           return query; 
        }

        private void Btn_genee_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearInsert());
            Mostraremp();
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            txt_correo.Text = "";
            Txt_cui.Text = "";
            Txt_dire.Text = "";
            Txt_nit.Text = "";
            Cbo_sex.Text = "";
            combo1.llenarse("puestos", "id_puesto", "nombre");
            combo2.llenarse("area", "id_area", "nombre");
            Btn_genee.Enabled = false;
            Btn_new.Enabled = true;
            dataGridView2.Enabled = false;
            Txt_id.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_apellido.Enabled = false;
            Cbo_sex.Enabled = false;
            Txt_cui.Enabled = false;
            txt_correo.Enabled = false;
            combo1.Enabled = false;
            combo2.Enabled = false;
            Txt_nit.Enabled = false;
            Txt_dire.Enabled = false;
            DTP_fechana.Enabled = false;
            Btn_can.Enabled = false;
        }

        private void EmpleaodosCom_Load(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                debehaber = "1";
            
            }
            else
            {
                MessageBox.Show("Error!");
            }
          
        }
        string crearInsertcon()// crea el query de insert
        {
            string query = "INSERT INTO `conceptos` (`id_concepto`, `id_empleado`, `fecha_inicio`, `fecha_fin`, `id_tipo`, `monto`, `debe_Haber`, `estado`) VALUES (NULL, '"+Txt_emplecon.Text+"', '"+ fechaini + "', '"+ fechafin + "', '"+combo3.obtener()+"', '"+Txt_montocon.Text+"', '"+ debehaber + "', '1');";
            return query;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txt_apellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Cbo_sex.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Txt_cui.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_correo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Txt_nit.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
                Txt_dire.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                Txt_emplecon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Mostrarcon(Txt_emplecon.Text);
                Btn_geeecon.Enabled = true;

                Txt_id.Enabled = false;
                Txt_nombre.Enabled = false;
                Txt_apellido.Enabled = false;
                Cbo_sex.Enabled = false;
                Txt_cui.Enabled = false;
                txt_correo.Enabled = false;
                combo1.Enabled = false;
                combo2.Enabled = false;
                Txt_nit.Enabled = false;
                Txt_dire.Enabled = false;
                Btn_new.Enabled = false;
                DTP_fechana.Enabled = false;
                Btn_genee.Enabled = false;

               
                combo3.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                Txt_montocon.Enabled = true;
                checkBox1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_geeecon_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearInsertcon());
            Mostrarcon(Txt_emplecon.Text);
         
            Txt_montocon.Text = "";
             radioButton2.Checked = true;
            checkBox1.Checked = false;

        }

      
            private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = true;
               
                fechaini = dateTimePicker2.Text;
                fechafin = dateTimePicker3.Text;
               
            } else if (checkBox1.Checked == false)
            {
                fechaini = "1111-11-11";
                fechafin = "1111-11-11";
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;
               
            }
            else {
                MessageBox.Show("Error!");
            }
 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            debehaber = "0";
      
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            debehaber = "1";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_nuevoreg_Click(object sender, EventArgs e)
        {

            Txt_id.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_apellido.Enabled = true;
            Cbo_sex.Enabled = true;
            Txt_cui.Enabled = true;
            txt_correo.Enabled = true;
            combo1.Enabled = true;
            combo2.Enabled = true;
            Txt_nit.Enabled = true;
            Txt_dire.Enabled = true;
            Btn_new.Enabled = true;
            DTP_fechana.Enabled = true;
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            Cbo_sex.Text = "";
            Txt_cui.Text = "";
            txt_correo.Text = "";
            combo1.Text = "";
            combo2.Text = "";
            Txt_nit.Text = "";
            Txt_dire.Text = "";
            Btn_new.Text = "";
            DTP_fechana.Text = "";
            Btn_genee.Enabled = false;
           
            Txt_montocon.Text = "";

            radioButton2.Checked = true;
            checkBox1.Checked = false;

        
            combo3.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            Txt_montocon.Enabled = false;
            checkBox1.Enabled = false;
            Mostrarcon("0");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Btn_genee.Enabled = false;
            Btn_new.Enabled = true;
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            txt_correo.Text = "";
            Txt_cui.Text = "";
            Txt_dire.Text = "";
            Txt_nit.Text = "";
            Cbo_sex.Text = "";
            Btn_can.Enabled = false;
            Txt_id.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_apellido.Enabled = false;
            Cbo_sex.Enabled = false;
            Txt_cui.Enabled = false;
            txt_correo.Enabled = false;
            combo1.Enabled = false;
            combo2.Enabled = false;
            Txt_nit.Enabled = false;
            Txt_dire.Enabled = false;
            DTP_fechana.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Btn_genee.Enabled = true;
            Btn_new.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_apellido.Enabled = true;
            Cbo_sex.Enabled = true;
            Txt_cui.Enabled = true;
            txt_correo.Enabled = true;
            combo1.Enabled = true;
            combo2.Enabled = true;
            Txt_nit.Enabled = true;
            Txt_dire.Enabled = true;
            DTP_fechana.Enabled = true;
            Btn_can.Enabled = true;
        }
    }
}
