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
    public partial class REContrataciones : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        public REContrataciones(string user)
        {
            InitializeComponent();
            usuario = user;
            LblUsuario.Text = usuario;
            Mostraremp();
            progres();
        }
        string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE empleados set estado = 1 WHERE id_empleado =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            return query;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica2();
            dataGridView1.DataSource = dt;
        }
        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
            }

        }
        /*Busquedas*/
        void MostrarCOD(string dato)
        {
            DataTable dt = logic.consultaLogicacod2(dato);
            dataGridView1.DataSource = dt;
        }
        void MostrarNOMA(string nom, string ap)
        {
            DataTable dt = logic.consultaLogicanoma2(nom, ap);
            dataGridView1.DataSource = dt;
        }
        /**/
        private void Contrataciones_Load(object sender, EventArgs e)
        {
            progres();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txt_apellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Txt_sexo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                DTP_fechana.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Txt_cui.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Txt_correo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Txt_puesto.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                Txt_area.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Txt_nit.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                Txt_direccion.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                Btn_Des.Enabled = true;
                progres();
                


            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_recar_Click(object sender, EventArgs e)
        {
            Mostraremp();
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            Txt_id.Text = "";
            Txt_nit.Text = "";
            Txt_direccion.Text = "";
            Txt_cui.Text = "";
            Txt_correo.Text = "";
            Txt_sexo.Text = "";
            Txt_area.Text = "";
            Txt_puesto.Text = "";
            Txt_nombreb.Text = "";
            Txt_apellidoB.Text = "";
            Txt_Codigo.Text = "";
            progres();
        }

        private void Btn_Des_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado fue recontratado");
            logic.nuevoQuery(crearDelete());
            Mostraremp();
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            Txt_id.Text = "";
            Txt_nit.Text = "";
            Txt_direccion.Text = "";
            Txt_cui.Text = "";
            Txt_correo.Text = "";
            Txt_sexo.Text = "";
            Txt_area.Text = "";
            Txt_puesto.Text = "";
            progres();
        }

        private void btn_nomap_Click(object sender, EventArgs e)
        {
            MostrarNOMA(Txt_nombreb.Text, Txt_apellidoB.Text);
            progres();
            ProgressBar1.Style = ProgressBarStyle.Marquee;
            Txt_nombreb.Text = "";
            Txt_apellidoB.Text = "";
        }

        private void btn_cod_Click(object sender, EventArgs e)
        {
            MostrarCOD(Txt_Codigo.Text);
            Txt_Codigo.Text = "";
            progres();
            ProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "Recontrataciones.html");
        }
    }
}
