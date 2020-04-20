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
using System.IO;
using System.Net;



namespace CapaVistaHRM
{
    public partial class Planilla : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        Modeloplanilla logic = new Modeloplanilla();
        DateTime hoy = DateTime.Now;
        string tabla = "def";
        string user;
        string IDPLA;
        string fechai;
        string fechaf;
        string fechahora;
        string prueba;
   
        
              public Planilla(string usuario)
        {
            InitializeComponent();
            DTP_fechai.Format = DateTimePickerFormat.Custom;
            DTP_fechai.CustomFormat = "yyyy-MM-dd";
            DTP_fechaf.Format = DateTimePickerFormat.Custom;
            DTP_fechaf.CustomFormat = "yyyy-MM-dd";
            fechahora = hoy.ToString("yyyy-MM-dd");
            Btn_generar.Enabled = false;
            Mostrarpla();
            user = usuario;
            LblUsuario.Text = usuario;
        }
        string crearInsert()// crea el query de insert
        {
            string query = "INSERT INTO `planilla` (`id_planilla`, `fecha_inicio`, `fecha_fin`, `Nombre`, `estado`) VALUES (NULL, '"+ DTP_fechai.Text+ "', '"+ DTP_fechaf.Text+ "', '"+Txt_nombre.Text+"', '1');";

            return query;

        }
        private void Planilla_Load(object sender, EventArgs e)
        {
            user = LblUsuario.Text;
        }
        void Mostrarpla()
        {
            DataTable dt = logic.consultaLogicaplani(tabla);
            dataGridView1.DataSource = dt;
        }
      
      
        private void button1_Click(object sender, EventArgs e)
        {
           logic.nuevoQuerypla(crearInsert());
            MessageBox.Show("Planilla Generada Corectamente");
            Mostrarpla();
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechai = fechahora;
            fechaf = fechahora;
            Btn_Insertar.Enabled = false;
            Btn_Nuevo.Enabled = true;
            Txt_nombre.Enabled = false;
            DTP_fechai.Enabled = false;
            DTP_fechaf.Enabled = false;

        }

    
        private void button5_Click(object sender, EventArgs e)
        {
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechai = fechahora;
            fechaf = fechahora;
            this.Hide();
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
                Btn_generar.Enabled = true;
                Btn_detalle.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        
        private void button2_Click(object sender, EventArgs e)
        { //string sql = "SELECT COUNT(detalle_planilla.id_detalle) as dato FROM planilla INNER JOIN detalle_planilla ON planilla.id_planilla = detalle_planilla.id_planilla WHERE detalle_planilla.id_planilla=" + ID + ";";


            if (logic.nuevovali(IDPLA) == "0")
            {
                logic.creardetalle(IDPLA, fechai, fechaf);
                MessageBox.Show("La planilla se genero Corectamente");
            }
            else
            {

                MessageBox.Show("La planilla ya fue creada");
                //   Console.WriteLine(sn.obtenerDatodde(IDPL) + "---------------------------------------------------------------------------------------------------------");

            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_detalle_Click(object sender, EventArgs e)
        {
            GenePlanilla nuevo = new GenePlanilla(user, IDPLA);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Btn_Insertar.Enabled = true;
            Txt_nombre.Enabled = true;
            DTP_fechai.Enabled = true;
            DTP_fechaf.Enabled = true;
            Btn_Nuevo.Enabled = false;
        }
    }
}
