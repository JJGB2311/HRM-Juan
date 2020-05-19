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
    public partial class Conceptos : Form
    {
        string usuario;
        string Codigo;
        string fechaini = "1111-11-11";
        string fechafin = "1111-11-11";
        string debehaber ;
        string fechai;
        string fechaf;
        string DBAB;
        string ID;
        string vacio = "";
      
        ModeloEmpleado logic = new ModeloEmpleado();
        public Conceptos(string user)
        {
            InitializeComponent();
            usuario = user;
            LblUsuario.Text = usuario;
            Mostraremp();
            combo3.llenarse("tipo_concepto", "id_tipo", "nombre");
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            //dataGridView2.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
          
        }
        string crearInsertcon()// crea el query de insert
        {
            string query = "INSERT INTO `conceptos` (`id_concepto`, `id_empleado`, `fecha_inicio`, `fecha_fin`, `id_tipo`, `monto`, `debe_Haber`, `estado`) VALUES (NULL, '" + Txt_Codigo2.Text + "', '" + fechaini + "', '" + fechafin + "', '" + combo3.obtener() + "', '" + Txt_montocon.Text + "', '" + debehaber + "', '1');";
            return query;

        }
        string crearupdatetcon()// crea el query de insert
        {
            string query = "UPDATE `conceptos` SET `fecha_inicio` = '" + fechaini + "', `fecha_fin` = '" + fechafin + "', `id_tipo` = '" + combo3.obtener() + "', `monto` = '" + Txt_montocon.Text + "', `debe_Haber` = '" + debehaber + "' WHERE `conceptos`.`id_concepto` =" + dataGridView2.CurrentRow.Cells[0].Value.ToString(); 
            return query;

        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica();
            dataGridView1.DataSource = dt;
        }
        /*Busquedas*/
        void MostrarCOD( string dato)
        {
            DataTable dt = logic.consultaLogicacod(dato);
            dataGridView1.DataSource = dt;
        }
        void MostrarNOMA(string nom, string ap)
        {
            DataTable dt = logic.consultaLogicanoma(nom,ap);
            dataGridView1.DataSource = dt;
        }
        /**/
        string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE `conceptos` SET `estado` = '0' WHERE `conceptos`.`id_concepto` = " + dataGridView2.CurrentRow.Cells[0].Value.ToString();
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
        private void Conceptos_Load(object sender, EventArgs e)
        {
            progres();
            if (radioButton2.Checked == true)
            {
                debehaber = "1";

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
     
        void Mostrarcon2(string emple)
        {
            DataTable dt = logic.consultaLogicacon2(emple);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridView2.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TipoConcepto nuevo = new TipoConcepto(usuario);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Txt_Codigo2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Mostrarcon2(Txt_Codigo2.Text);
                dataGridView2.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
                dataGridView2.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
                BTN_nuevo.Enabled = true;

            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                ID= dataGridView2.CurrentRow.Cells[0].Value.ToString();
                Txt_emplecon.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                fechaini = dataGridView2.CurrentRow.Cells[2].FormattedValue.ToString();
                fechafin = dataGridView2.CurrentRow.Cells[3].FormattedValue.ToString();
                Txt_montocon.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                DBAB = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                checkBox1.Checked = false;
                combo3.Enabled = false;
                Txt_montocon.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                checkBox1.Enabled = false;
                Btn_eliminar.Enabled = true; 

                if (fechaini == "1111-11-11")
                {
                    fechaini = "1111-11-11";
                    fechafin = "1111-11-11";
                    dateTimePicker2.Enabled = false;
                    dateTimePicker3.Enabled = false;
                    checkBox1.Checked = false;

                }
                else 
                {

                    dateTimePicker2.Enabled = true;
                    dateTimePicker3.Enabled = true;

                    fechai = dateTimePicker2.Text;
                    fechaf = dateTimePicker3.Text;
                    checkBox1.Checked = true;


                }

                if (DBAB == "0")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;

                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
            

            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        /********/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = true;

                fechaini = dateTimePicker2.Text;
                fechafin = dateTimePicker3.Text;

            }
            else if (checkBox1.Checked == false)
            {
                fechaini = "1111-11-11";
                fechafin = "1111-11-11";
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;

            }
            else
            {
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

        private void button4_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearInsertcon());
            Mostrarcon2(Txt_Codigo2.Text);

            Txt_montocon.Text = "";
            combo3.texto(vacio);
            radioButton2.Checked = true;
            checkBox1.Checked = false;
            combo3.Enabled = false;
            Txt_montocon.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            checkBox1.Enabled = false;
            btn_can.Enabled = false;
            BTN_nuevo.Enabled = true;
            Btn_eliminar.Enabled = false;
            BTN_insertar.Enabled = false;
            Txt_emplecon.Text = "";
            progres();
       

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearDelete());
            progres();
            Mostrarcon2(Txt_Codigo2.Text);
            Txt_montocon.Text = "";
            Txt_emplecon.Text = "";
            combo3.texto(vacio);
            radioButton2.Checked = true;
            checkBox1.Checked = false;
            combo3.Enabled = false;
            Txt_montocon.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            checkBox1.Enabled = false;
            btn_can.Enabled = false;
            BTN_nuevo.Enabled = true;
            Btn_eliminar.Enabled = false;
            BTN_insertar.Enabled = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarCOD(Txt_Codigo.Text); 
            progres();
            Txt_Codigo.Text = "";
            ProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Txt_Codigo.Enabled = false;
                TXT_APE.Enabled = true;
                TXT_NOM.Enabled = true;

            }
            else if (checkBox2.Checked == false)
            {
                Txt_Codigo.Enabled = true;
                TXT_APE.Enabled = false;
                TXT_NOM.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error!");
            }
            progres();
            ProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Txt_Codigo.Text="";
            TXT_APE.Text = "";
            TXT_NOM.Text = "";
            Mostraremp();
            progres();
            ProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearupdatetcon());
            progres();
            Mostrarcon2(Txt_Codigo2.Text);
            Txt_emplecon.Text = "";
            Txt_montocon.Text = "";
            MessageBox.Show("Modificado Corectamente");

        }

        private void Txt_Codigo_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNOMA(TXT_NOM.Text,TXT_APE.Text);
                 progres();
            TXT_APE.Text = "";
            TXT_NOM.Text = "";
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            combo3.Enabled = true;
            Txt_montocon.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            checkBox1.Enabled = true;
            btn_can.Enabled = true;
            Btn_eliminar.Enabled = false; ;
            BTN_insertar.Enabled = true;
            BTN_nuevo.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Mostraremp();
            TXT_APE.Text = "";
            TXT_NOM.Text = "";
            Txt_Codigo.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            combo3.Enabled = false;
            Txt_montocon.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            checkBox1.Enabled = false;
            btn_can.Enabled = false;
            Txt_montocon.Text = "";
            combo3.texto(vacio);
            Btn_eliminar.Enabled = false;
            BTN_insertar.Enabled = false;
            BTN_nuevo.Enabled = true;

        }

        private void Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);
        }

        private void TXT_NOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasimbolo(e);
        }

        private void TXT_APE_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasimbolo(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "mconceptos.html");
        }
    }
}
