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
        Modeloplanilla logic = new Modeloplanilla();
        DateTime hoy = DateTime.Now;
        string tabla = "def";
        string user;
        string IDPLA;
        string fechai;
        string fechaf;
        string fechahora;
   
        
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
          string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE planilla set estado = 0 "+" WHERE id_planilla =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            return query;
        }

       /* string crearUpdate()// crea el query de update
         {
             string query = "UPDATE ayuda SET Ruta = 'Página web ayuda/ayuda.chm.', indice = 'Menúboletos.html.' WHERE ayuda.Id_ayuda = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
             string query = "UPDATE ayuda SET Ruta = '" + txtruta.Text.Replace("\\", "/") + "', indice = '" + txtindice.Text + "' WHERE ayuda.Id_ayuda = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();


             return query;
         }*/
        private void button1_Click(object sender, EventArgs e)
        {
           logic.nuevoQuerydepla(crearInsert());
            Mostrarpla();
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechai = fechahora;
            fechaf = fechahora;


        }

        private void DTP_fecha_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechai = fechahora;
            fechaf = fechahora;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Btn_generar.Enabled = false;
            logic.nuevoQuerydepla(crearDelete());
            Mostrarpla();
            Txt_id.Text = "";
            Txt_nombre.Text = "";
            fechai = fechahora;
            fechaf = fechahora;
            Mostrarpla();
           
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
            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logic.creardetalle(IDPLA, fechai,fechaf);
            MessageBox.Show("BIEN");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_detalle_Click(object sender, EventArgs e)
        {
            GenePlanilla nuevo = new GenePlanilla(user, IDPLA);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }
    }
}
