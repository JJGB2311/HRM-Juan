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
    public partial class Empleos : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();

        string usuario;
        string ID;
        string vacio = "";
        public Empleos(string user ,string id)
        {
            InitializeComponent();
            usuario = user;
              ID=id;
            txt_soli.Text = id;
            combo1.llenarse("sueldos", "id_sueldo", "salario");
            LblUsuario.Text = usuario;
            lbl_ID.Text = ID;
            Mostraremp();
          Cbo_tipo.Items.Add("Temporal");
          Cbo_tipo.Items.Add("Indefinido");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

        }
            string crearInsert()// crea el query de insert
          {
             
                string query = "INSERT INTO `empleos` (`id_empleos`, `id_solicitud`, `id_sueldo`, `detalles`, `fecha`, `tipo`, `estado`) VALUES(NULL, '"+txt_soli.Text+"', '"+combo1.ObtenerIndif()+"', '"+txt_dta.Text+"', '"+dateTimePicker1.Text+"', '"+Cbo_tipo.Text+"', '1'); ";

                return query;
            }
        string crearInsert2()// crea el query de insert
        {
           
            string query = "UPDATE `solicitudes` SET `estado` = '2' WHERE `solicitudes`.`id_solicitud` = "+txt_soli.Text+"; ";

            return query;
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogiENP();
            dataGridView1.DataSource = dt;
        }
        private void Empleos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearInsert());
            logic.nuevoQuery(crearInsert2());
            Mostraremp();
            txt_no.Text = "";
            txt_soli.Text = "";
            txt_dta.Text = "";
            combo1.texto(vacio);
            Cbo_tipo.Text = "";
            btn_fin.Enabled = true;
            btn_gene.Enabled = false;
        }

        private void btn_fin_Click(object sender, EventArgs e)
        {
            txt_no.Text = "";
            txt_soli.Text = "";
            txt_dta.Text = "";
            combo1.texto(vacio);
            Cbo_tipo.Text = "";
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "Generarempleo.html");
        }
    }
}
