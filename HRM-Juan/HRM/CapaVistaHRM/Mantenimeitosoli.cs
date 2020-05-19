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
    public partial class Mantenimeitosoli : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        string vacio = "";
        string ID;
        string perfil, area, puesto;
        public Mantenimeitosoli(string user)
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
      
        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
            }

        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogisoli();
            dataGridView1.DataSource = dt;
        }
        string crearInsert()// crea el query de insert
        {
            string query = "INSERT INTO `solicitudes` (`id_solicitud`, `id_perfil`, `id_area`, `fecha`, `detalles`, `Cantidad`, `motivo`, `id_puesto`, `porcentaje`, `estado`) VALUES (NULL, '"+combo1.ObtenerIndif()+ "', '"+combo2.ObtenerIndif()+"', '" + DTP_fecha.Text + "', '"+txt_deta.Text+"', '"+txt_canti.Text+ "', '"+txt_motivo.Text+"', '" + combo3.ObtenerIndif() + "', '50', '1');";
            return query;
        }

        string crearDelite()// crea el query de insert
        {
            string query = "UPDATE `solicitudes` SET `estado` = '0' WHERE `solicitudes`.`id_solicitud` = " + txt_no.Text + ";";
            return query;
        }

        private void Mantenimeitosoli_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearInsert());
            Mostraremp();
            txt_no.Text = "";
            txt_motivo.Text = "";
            txt_deta.Text = "";
            txt_canti.Text = "";
            combo1.texto(vacio);
            combo2.texto(vacio);
            combo3.texto(vacio);
            BTN_generar.Enabled = false;
            Btn_nuevo.Enabled = true;
            BTN_cancelar.Enabled = false;

            txt_motivo.Enabled = false;
            txt_deta.Enabled = false;
            txt_canti.Enabled = false;
            combo1.Enabled = false;
            combo2.Enabled = false;
            combo3.Enabled = false;
            DTP_fecha.Enabled = false;
            progres();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                perfil = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                area = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                DTP_fecha.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
                txt_deta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_canti.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_motivo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                puesto = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                combo1.texto(perfil);
                combo2.texto(area);
                combo3.texto(puesto);
                Btn_borrar.Enabled = true;
                BTN_cancelar.Enabled = true;
                ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                progres();


            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearDelite());
            Mostraremp();
            txt_no.Text = "";
            txt_motivo.Text = "";
            txt_deta.Text = "";
            txt_canti.Text = "";
            combo1.texto(vacio);
            combo2.texto(vacio);
            combo3.texto(vacio);
            BTN_generar.Enabled = false;
            Btn_nuevo.Enabled = true;
            BTN_cancelar.Enabled = false;
            Btn_borrar.Enabled = false;

            txt_motivo.Enabled = false;
            txt_deta.Enabled = false;
            txt_canti.Enabled = false;
            combo1.Enabled = false;
            combo2.Enabled = false;
            combo3.Enabled = false;
            DTP_fecha.Enabled = false;
            progres();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "Generarsolicitud.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BTN_generar.Enabled = false;
            Btn_nuevo.Enabled = true;
            txt_no.Text = "";
            txt_motivo.Text = "";
            txt_deta.Text = "";
            txt_canti.Text = "";
            combo1.texto(vacio);
            combo2.texto(vacio);
            combo3.texto(vacio);
            BTN_cancelar.Enabled = false;

            txt_motivo.Enabled = false;
            txt_deta.Enabled = false;
            txt_canti.Enabled = false;
            combo1.Enabled = false;
            combo2.Enabled = false;
            combo3.Enabled = false;
            DTP_fecha.Enabled = false;
            Btn_borrar.Enabled = false;
            progres();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BTN_generar.Enabled = true;
            Btn_nuevo.Enabled = false;
            txt_no.Text = "";
            txt_motivo.Text = "";
            txt_deta.Text = "";
            txt_canti.Text = "";
            combo1.texto(vacio);
            combo2.texto(vacio);
            combo3.texto(vacio);
            BTN_cancelar.Enabled = true;


         
            txt_motivo.Enabled = true;
            txt_deta.Enabled = true;
            txt_canti.Enabled = true;
            combo1.Enabled = true;
            combo2.Enabled = true;
            combo3.Enabled = true;
            DTP_fecha.Enabled = true;
            progres();

        }
    }
}
