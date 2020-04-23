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
        ModeloEmpleado logic = new ModeloEmpleado();
        public Conceptos(string user)
        {
            InitializeComponent();
            user = usuario;
            LblUsuario.Text = usuario;
            Mostraremp();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogica();
            dataGridView1.DataSource = dt;
        }
        private void Conceptos_Load(object sender, EventArgs e)
        {

        }
        void Mostrarcon(string emple)
        {
            DataTable dt = logic.consultaLogicacon(emple);
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
                Txt_Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Mostrarcon(Txt_Codigo.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
               /* Txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txt_apellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Cbo_sex.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Txt_cui.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_correo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();*/
               
            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
