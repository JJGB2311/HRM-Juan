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
    public partial class Mantenifini : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario;
        public Mantenifini(string user)
        {
            InitializeComponent();
            Mostraremp();
            usuario = user;
            LblUsuario.Text = usuario;
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogicafini();
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
        private void Mantenifini_Load(object sender, EventArgs e)
        {
            progres();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               Txt_prestaciones.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Txt_motivo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Txt_descrip.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             
                progres();
                ProgressBar1.Style = ProgressBarStyle.Marquee;

            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "MFiniquito.html");
        }
    }
}
