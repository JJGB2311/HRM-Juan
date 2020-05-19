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
           Txt_emplecon.Text= logic.nuevoEMPCON();
        }
        void Mostrarcon(string emple)
        {
            DataTable dt = logic.consultaLogicacon(emple);
            dataGridView2.DataSource = dt;
        }
        string crearInsertcon()// crea el query de insert
        {
            string query = "INSERT INTO `conceptos` (`id_concepto`, `id_empleado`, `fecha_inicio`, `fecha_fin`, `id_tipo`, `monto`, `debe_Haber`, `estado`) VALUES (NULL, '" + Txt_emplecon.Text + "', '" + dateTimePicker2.Text + "', '" + dateTimePicker3.Text + "', '" + combo3.ObtenerIndif() + "', '" + Txt_montocon.Text + "', '" + debehaber + "', '1');";
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
            logic.nuevoQuery(crearInsertcon());
            Mostrarcon(Txt_emplecon.Text);
            progres();
            Txt_montocon.Text = "";
            radioButton2.Checked = true;
            checkBox1.Checked = false;
            combo3.texto(vacio);           
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
    }
}
