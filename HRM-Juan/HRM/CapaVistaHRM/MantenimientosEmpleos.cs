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
    public partial class MantenimientosEmpleos : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();

        string usuario;
        string sueldo;
        string vacio = "";
        public MantenimientosEmpleos(string user)
        {
            InitializeComponent();
            Mostraremp();
            usuario = user;
            LblUsuario.Text = usuario;
            combo1.llenarse("sueldos", "id_sueldo", "salario");
            Cbo_tipo.Items.Add("Temporal");
            Cbo_tipo.Items.Add("Indefinido");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogiENP();
            dataGridView1.DataSource = dt;
        }
        private void MantenimientosEmpleos_Load(object sender, EventArgs e)
        {
            progres();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        string crearUPDATE()// crea el query de insert
        {
            string query = "UPDATE `empleos` SET `id_sueldo` = '"+combo1.ObtenerIndif()+"', detalles = "+ TEX_DETA.Text+", `fecha` = '"+dateTimePicker1.Text+"', `tipo` = '"+Cbo_tipo.Text+"' WHERE `empleos`.`id_empleos` = "+txt_no.Text+";";

            return query;
        }
        string crearDELETE()// crea el query de insert
        {

            string query = "UPDATE `empleos` SET `estado` = '0' WHERE `empleos`.`id_empleos` = " + txt_no.Text + ";";

            return query;
        }
        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
            }

        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_soli.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sueldo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TEX_DETA.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Cbo_tipo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                combo1.texto(sueldo);
                btn_borrar.Enabled = true;
                btn_modificar.Enabled = true;
                Cbo_tipo.Enabled = true;
                combo1.Enabled = true;
                TEX_DETA.Enabled = true;
                dateTimePicker1.Enabled = true;
                progres();

            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

            logic.nuevoQuery(crearDELETE());
            Mostraremp();
      
            Cbo_tipo.Text = "";
            txt_no.Text = "";
            Txt_soli.Text = "";
            TEX_DETA.Text = "";
            combo1.texto(vacio);
            Cbo_tipo.Text = "";

            Txt_soli.Enabled = false;
            Cbo_tipo.Enabled = false;
            combo1.Enabled = false;
            TEX_DETA.Enabled = false;
            dateTimePicker1.Enabled = false;
            btn_borrar.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearUPDATE());
            Mostraremp();
            txt_no.Text = "";
            Txt_soli.Text = "";
            TEX_DETA.Text = "";
            combo1.texto(vacio);
            Cbo_tipo.Text = "";

            Txt_soli.Enabled = false;
            Cbo_tipo.Enabled = false;
            combo1.Enabled = false;
            TEX_DETA.Enabled = false;
            dateTimePicker1.Enabled = false;
            btn_borrar.Enabled = false;
            btn_modificar.Enabled = false;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "mEmpleos.html");
        }
    }
}