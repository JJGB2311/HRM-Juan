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
    public partial class Despidos : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        string id;
        public Despidos(string user)
        {
            InitializeComponent();
            usuario = user;
            LblUsuario.Text = usuario;
            Mostraremp();
            progres();
        }

        private void Btn_Modi_Click(object sender, EventArgs e)
        {
            
          
            Mostraremp();
            Finiquitos nuevo = new Finiquitos(usuario, id);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
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
            Txt_Codigo.Enabled = false;
            Txt_apellidoB.Enabled = false;
            Txt_nombreb.Enabled = false;
            btn_nomap.Enabled = false;
            btn_cod.Enabled = false;
            btn_recar.Enabled = false;
            Btn_Des.Enabled = false;
               

            progres();
            this.Close();
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica();
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
       
        private void Despidos_Load(object sender, EventArgs e)
        {
            progres();
        }
        /*Busquedas*/
        void MostrarCOD(string dato)
        {
            DataTable dt = logic.consultaLogicacod(dato);
            dataGridView1.DataSource = dt;
        }
        void MostrarNOMA(string nom, string ap)
        {
            DataTable dt = logic.consultaLogicanoma(nom, ap);
            dataGridView1.DataSource = dt;
        }
        /**/
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

                Btn_Des.Enabled = true;
                progres();

               
            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
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
            progres();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarCOD(Txt_Codigo.Text);
            progres();
            Txt_Codigo.Text = "";
            ProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNOMA(Txt_nombreb.Text, Txt_apellidoB.Text);
            progres();
            Txt_apellidoB.Text = "";
            Txt_nombreb.Text = "";
            ProgressBar1.Style = ProgressBarStyle.Marquee;
        }
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

        private void Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "Despedir.html");
        }
    }
}
