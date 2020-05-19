using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloHRM;
using System.Data.Odbc;

namespace CapaVistaHRM
{
    public partial class MantenimientoPlanilla : Form
    {
        OdbcConnection cn = new OdbcConnection("Dsn=ERP");
        Modeloplanilla logic = new Modeloplanilla();
        DateTime hoy = DateTime.Now;
        string tabla = "def";
        string user;
        string fechahora;
        string fechai;
        string fechaf;
        string IDPLA;


        public MantenimientoPlanilla(string usuario)
        {
            InitializeComponent();
            user = usuario;
            LblUsuario.Text = usuario;
            Mostrarpla();
            DTP_fechai.Format = DateTimePickerFormat.Custom;
            DTP_fechai.CustomFormat = "yyyy-MM-dd";
            DTP_fechaf.Format = DateTimePickerFormat.Custom;
            DTP_fechaf.CustomFormat = "yyyy-MM-dd";
           
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechai = fechahora;
            fechaf = fechahora;
           
        }
        void Mostrarpla()
        {
            DataTable dt = logic.consultaLogicaplani(tabla);
            dataGridView1.DataSource = dt;
        }
        string crearDelete()// crea el query de delete
        {
            string query = "UPDATE planilla set estado = 0 " + " WHERE id_planilla =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            return query;
        }

      string crearUpdate(string ID , string FechaI , string FechaF)// crea el query de update
        {
            string query = "UPDATE `planilla` SET `fecha_inicio` = '"+ FechaI + "', `fecha_fin` = '"+ FechaF + "', `Nombre` = '"+Txt_nombre.Text+"' WHERE `planilla`.`id_planilla` = "+ID+";" ;
            return query;
        }
       
        void Mostrarpla2(string dato)
        {
            DataTable dt = logic.consultaLogicadet(dato);
            dataGridView2.DataSource = dt;
        }
      
        private void Btn_Insertar_Click(object sender, EventArgs e)
        { 
            logic.nuevoQuerydepla(crearDelete());
            Mostrarpla();
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechai = fechahora;
            fechaf = fechahora;
            Mostrarpla2("0");
            Btn_Modificar.Enabled = false;
            Btn_Borar.Enabled = false;
            Txt_id.Enabled = false;
            Txt_nombre.Enabled = false;
            DTP_fechai.Enabled = false;
            DTP_fechaf.Enabled = false;
            MessageBox.Show("La planilla se elimino corectamente");
            ProgressBar1.Style = ProgressBarStyle.Continuous;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DTP_fechai.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                DTP_fechaf.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Txt_nombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                IDPLA = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                fechai = DTP_fechai.Text;
                fechaf = DTP_fechaf.Text;
                Txt_id.Enabled = false;
                Txt_nombre.Enabled = true;
                DTP_fechai.Enabled = true;
                DTP_fechaf.Enabled = true;
                Btn_Borar.Enabled = true;
                Btn_Modificar.Enabled = true;
                Mostrarpla2(IDPLA);
                LBL_Total.Text = logic.Totalpla(IDPLA);
                TOTAL.Text = logic.Totalpla(IDPLA);
                progres();
                ProgressBar1.Style = ProgressBarStyle.Marquee;

            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            logic.nuevoQuerydepla(crearUpdate(IDPLA, DTP_fechai.Text, DTP_fechaf.Text));
            Mostrarpla();
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechai = fechahora;
            fechaf = fechahora;
            Mostrarpla2("0");
            Btn_Modificar.Enabled = false;
            Btn_Borar.Enabled = false;
            Txt_id.Enabled = false;
            Txt_nombre.Enabled = false;
            DTP_fechai.Enabled = false;
            DTP_fechaf.Enabled = false;
            MessageBox.Show("El encabezado de la planilla se modifico corectamente");
            ProgressBar1.Style = ProgressBarStyle.Continuous;
            progres();
        }
        private void Btn_generar_Click(object sender, EventArgs e)
        {
            logic.creardetalle(IDPLA, DTP_fechai.Text, DTP_fechaf.Text);
            MessageBox.Show("Detalle Generado Corectamente");
            Mostrarpla2(IDPLA);
            Btn_Modificar.Enabled = false;
            Btn_Borar.Enabled = false;
            Txt_id.Enabled = false;
            Txt_nombre.Enabled = false;
            DTP_fechai.Enabled = false;
            DTP_fechaf.Enabled = false;
        }

       
        private void MantenimientoPlanilla_Load(object sender, EventArgs e)
        {
            progres();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "mPlanilla.html");
        }
    }
}
