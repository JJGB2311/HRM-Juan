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
    public partial class EmpleadosCon : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string tabla = "def";
        string fechana;
        string usuario;
        
        public EmpleadosCon(string user)
        {
            InitializeComponent();
            Mostraremp();
            user = usuario;
            LblUsuario.Text = usuario;
            DTP_fechana.Format = DateTimePickerFormat.Custom;
            DTP_fechana.CustomFormat = "yyyy-MM-dd";
            Cbo_sex.Items.Add("Masculino");
            Cbo_sex.Items.Add("Femenino");
            combo1.llenarse("puestos", "id_puesto", "nombre");
            combo2.llenarse("area", "id_area", "nombre");

            progres();
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica();
            dataGridView1.DataSource = dt;
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

            BTN_Sig.Enabled = true;
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
            progres();
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
           
            DTP_fechana.Text = "";
            Btn_genee.Enabled = false;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Btn_genee.Enabled = true;
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            txt_correo.Text = "";
            Txt_cui.Text = "";
            Txt_dire.Text = "";
            Txt_nit.Text = "";
            Cbo_sex.Text = "";
            BTN_Sig.Enabled = false;
            Txt_id.Enabled = false;
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Btn_genee.Enabled = true;
           
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
            progres();
        }

        private void Btn_agrecon_Load(object sender, EventArgs e)
        {

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
           Asignacioncone nuevo = new Asignacioncone(usuario);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
