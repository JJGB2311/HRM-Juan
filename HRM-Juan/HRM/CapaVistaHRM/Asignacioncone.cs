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
    public partial class Asignacioncone : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        string fechaini = "1111-11-11";
        string fechafin = "1111-11-11";
        string debehaber;
        string vacio = "";
        string[] empleados;
        string A; //CAPTURAMOS LOS DATOS DE LA COLUMNA 0 Y 1 
        string B ;
        string C ;
        string D ;
        string E;
         public Asignacioncone(string user)
        {
            InitializeComponent();
            usuario = user;
            LblUsuario.Text = usuario;
            lbl_ID.Text=logic.nuevoEMPCON();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            combo3.llenarse("tipo_concepto", "id_tipo", "nombre");
         //  Txt_emplecon.Text= logic.nuevoEMPCON();
            Mostraremp();
        }
       
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica();
            dataGridView1.DataSource = dt;
        }
        
        string crearInsertcon(string dato)// crea el query de insert
        {
            string query = "INSERT INTO `conceptos` (`id_concepto`, `id_empleado`, `fecha_inicio`, `fecha_fin`, `id_tipo`, `monto`, `debe_Haber`, `estado`) VALUES (NULL, '" + dato + "', '" + dateTimePicker2.Text + "', '" + dateTimePicker3.Text + "', '" + combo3.ObtenerIndif() + "', '" + Txt_montocon.Text + "', '" + debehaber + "', '1');";
            return query;
        }
        
        private void Asignacioncone_Load(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            debehaber = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            debehaber = "1";
        }
        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
            }

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

        private void Btn_geeecon_Click(object sender, EventArgs e)
        {

            if (dataGridView3.Rows.Count > 0)
              {
                  foreach (DataGridViewRow row in dataGridView3.Rows)
                  {

                      string prueba = row.Cells[0].Value.ToString();
                      logic.nuevoQuery(crearInsertcon(prueba));

                  }

                  MessageBox.Show("Conceptos agregados corectamente!!");

              }

             progres();
            Txt_montocon.Text = "";
            radioButton2.Checked = true;
            checkBox1.Checked = false;
            combo3.texto(vacio);
            dataGridView3.Rows.Clear();
            Mostraremp();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado y sus conceptos se registraron corectamente");
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "contraconcep.html");
        }

    
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            A = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); //CAPTURAMOS LOS DATOS DE LA COLUMNA 0 Y 1 
            B = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            C = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            D = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            E = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dataGridView3.Rows.Add(A, B, C, D, E);//ENVIAMOS DATOS CAPTURADOS A LA DG1
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
            {
                dataGridView3.Rows.RemoveAt(item.Index);
            }
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Txt_montocon.Text = "";
            radioButton2.Checked = true;
            checkBox1.Checked = false;
            combo3.texto(vacio);
            dataGridView3.Rows.Clear();
            Mostraremp();
        }
    }
}
