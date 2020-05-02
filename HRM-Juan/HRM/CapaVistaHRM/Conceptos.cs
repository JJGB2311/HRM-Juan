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
      
        ModeloEmpleado logic = new ModeloEmpleado();
        public Conceptos(string user)
        {
            InitializeComponent();
            user = usuario;
            LblUsuario.Text = usuario;
            Mostraremp();
            combo3.llenarse("tipo_concepto", "id_tipo", "nombre");
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
        }
        string crearInsertcon()// crea el query de insert
        {
            string query = "INSERT INTO `conceptos` (`id_concepto`, `id_empleado`, `fecha_inicio`, `fecha_fin`, `id_tipo`, `monto`, `debe_Haber`, `estado`) VALUES (NULL, '" + Txt_emplecon.Text + "', '" + fechaini + "', '" + fechafin + "', '" + combo3.obtener() + "', '" + Txt_montocon.Text + "', '" + debehaber + "', '1');";
            return query;

        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica();
            dataGridView1.DataSource = dt;
        }
        string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE `conceptos` SET `estado` = '0' WHERE `conceptos`.`id_concepto` = " + dataGridView2.CurrentRow.Cells[0].Value.ToString();
            return query;
        }
        private void Conceptos_Load(object sender, EventArgs e)
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
     
        void Mostrarcon2(string emple)
        {
            DataTable dt = logic.consultaLogicacon2(emple);
            dataGridView2.DataSource = dt;
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
                Txt_emplecon.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                fechaini = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                fechafin = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                Txt_montocon.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                DBAB = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            
                label6.Text = fechaini;

              
                combo3.Enabled = true;
                Txt_montocon.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                checkBox1.Enabled = true;

                if (fechaini == "1111-11-11 12:00:00")
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
            Mostrarcon2(Txt_emplecon.Text);

            Txt_montocon.Text = "";
            radioButton2.Checked = true;
            checkBox1.Checked = false;

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearDelete());

            Txt_emplecon.Text = "";
            Txt_montocon.Text = "";
        }
    }
}
