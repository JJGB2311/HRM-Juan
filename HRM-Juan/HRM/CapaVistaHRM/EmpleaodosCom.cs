﻿using System;
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
        string usuario;
        string vacio = "";
        string valor = "NO";
        public EmpleadosCon(string user)
        {
            InitializeComponent();
            Mostraremp();
            usuario = user;
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
            string query = "INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `fecha_de_nacimiento`, `cui`, `correo`, `id_puesto`, `id_area`, `nit`, `direccion`, `estado`) VALUES (NULL,'" + Txt_nombre.Text + "', '" + Txt_apellido.Text + "', '" + Cbo_sex.Text + "', '" + DTP_fechana.Text + "', '" + Txt_cui.Text + "', '" + txt_correo.Text + "', '" + combo1.ObtenerIndif() + "', '" + combo2.obtener() + "', '" + Txt_nit.Text + "', '" + Txt_dire.Text + "', '1');";
            return query;
        }

        private void Btn_genee_Click(object sender, EventArgs e)
        {
            string contenido = combo1.texto2();
            int existe = combo1.existe(contenido);
            if (existe == -1)
            {
                MessageBox.Show("El dato ingresado es incorecto!!");
            }
            logic.nuevoQuery(crearInsert());
            Mostraremp();
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            txt_correo.Text = "";
            Txt_cui.Text = "";
            Txt_dire.Text = "";
            Txt_nit.Text = "";
            Cbo_sex.Text = "";
            combo1.texto(vacio);
            combo2.texto(vacio);
            Btn_genee.Enabled = false;
            BTN_Sig.Enabled = true;
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
            MessageBox.Show("El empleado se registró correctamente. Para continuar seleccione el boton siguiente Nota (si cierra el formulario sin seleccionar el boton siguiente el registro no tendrá conceptos asignados)");
        }

        private void Btn_nuevoreg_Click(object sender, EventArgs e)
        {
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
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            txt_correo.Text = "";
            Txt_cui.Text = "";
            Txt_dire.Text = "";
            Txt_nit.Text = "";
            Cbo_sex.Text = "";
            BTN_Sig.Enabled = false;
            MessageBox.Show("El Reguistro se cancelo corectamente!!");


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
        private void Btn_agrecon_Load(object sender, EventArgs e)
        {
            progres();
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
            valor = "si";
            Asignacioncone nuevo = new Asignacioncone(usuario);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
        }

        private void EmpleadosCon_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Btn_genee.Enabled == false)
            {
                if (valor == "si")
                {
                    e.Cancel = false;
                }
                else { e.Cancel = true; }

            }
            else if (Btn_genee.Enabled == true)
            {
                e.Cancel = false;
            }
        }

        private void Cbo_sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            letracombo(e);
        }

        private void Txt_cui_KeyPress(object sender, KeyPressEventArgs e)
        {
            numero(e);
        }

        private void Txt_nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            numerosimbolo(e);
        }
    }
}
