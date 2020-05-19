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
    public partial class Solicitudes : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        string vacio = "";
        string ID;
        string perfil, area, puesto;
        public Solicitudes(string user)
        {
            InitializeComponent();
            usuario = user;
            LblUsuario.Text = usuario;
            DTP_fecha.Format = DateTimePickerFormat.Custom;
            DTP_fecha.CustomFormat = "yyyy-MM-dd";
            combo1.llenarse("perfiles", "id_perfil", "nombre");
            combo2.llenarse("area", "id_area", "nombre");
            combo3.llenarse("puestos", "id_puesto", "nombre");
            Mostraremp();
            progres();
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogisoli();
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
        private void Solicitudes_Load(object sender, EventArgs e)
        {
            progres();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Perfiles nuevo = new Perfiles(usuario,"2");
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_cantidad.Text = "";
            txt_detalle.Text = "";
            txt_motivo.Text = "";
            txt_no.Text = "";
            Mostraremp();
            combo1.texto(vacio);
            combo2.texto(vacio);
            combo3.texto(vacio);
            Btn_gener.Enabled = false;
            BTN_CAN.Enabled = false;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "Solicitudes.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleos nuevo = new Empleos(usuario ,ID);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
            txt_cantidad.Text = "";
            txt_detalle.Text = "";
            txt_motivo.Text = "";
            txt_no.Text = "";
            Mostraremp();
            combo1.texto(vacio);
            combo2.texto(vacio);
            combo3.texto(vacio);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                perfil = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                area= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                DTP_fecha.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
                txt_detalle.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_cantidad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_motivo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                puesto = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                combo1.texto(perfil);
                combo2.texto(area);
                combo3.texto(puesto);

                ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                Btn_gener.Enabled = true;
                progres();


            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
