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
    public partial class Mantenimientodes : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        string id;
        public Mantenimientodes(string user)
        {
            InitializeComponent();
            Mostrardes();
            usuario = user;
            LblUsuario.Text = usuario;
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
        private void Mantenimientodes_Load(object sender, EventArgs e)
        {
            progres();
        }
        void Mostrardes()
        {
            DataTable dt = logic.consultaLogicades();
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
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                
                progres();

                Mostrardes();
            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            Txt_puesto.Text = "";
            Txt_sexo.Text = "";
            Txt_direccion.Text = "";
            Txt_area.Text = "";
            Txt_apellido.Text = "";
            Txt_correo.Text = "";
            Txt_nit.Text = "";
            Txt_Codigo.Text = "";
            Txt_nombreb.Text = "";
            Txt_apellidoB.Text = "";


            Mostrardes();
            progres();
        }

        private void btn_cod_Click(object sender, EventArgs e)
        {
            MostrarCOD(Txt_Codigo.Text);
            progres();
            ProgressBar1.Style = ProgressBarStyle.Marquee;
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            Txt_puesto.Text = "";
            Txt_sexo.Text = "";
            Txt_direccion.Text = "";
            Txt_area.Text = "";
            Txt_apellido.Text = "";
            Txt_correo.Text = "";
            Txt_nit.Text = "";
            Txt_Codigo.Text = "";
            btn_cod.Enabled = false;
        }

        private void btn_nomap_Click(object sender, EventArgs e)
        {
            MostrarNOMA(Txt_nombreb.Text, Txt_apellidoB.Text);
            progres();
            ProgressBar1.Style = ProgressBarStyle.Marquee;
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            Txt_puesto.Text = "";
            Txt_sexo.Text = "";
            Txt_direccion.Text = "";
            Txt_area.Text = "";
            Txt_apellido.Text = "";
            Txt_correo.Text = "";
            Txt_nit.Text = "";
            Txt_nombreb.Text = "";
            Txt_apellidoB.Text = "";
            btn_nomap.Enabled = false;
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
        private void Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);
            btn_cod.Enabled = true;
        }

        private void Txt_nombreb_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasimbolo(e);
            btn_nomap.Enabled = true;
        }

        private void Txt_apellidoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasimbolo(e);
            btn_nomap.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "MDespedidos.html");
        }
    }
}
