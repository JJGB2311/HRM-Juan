using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace CapaVistaHRM
{
    public partial class MDI_HRM : Form
    {
        private int childFormNumber = 0;
        
        string usuarioact;
        string id; string fechai, fechaf;
        public MDI_HRM()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDI_HRM_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            LblUsuario.Text = login.obtenerNombreUsuario();
            usuarioact = LblUsuario.Text;
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(LblUsuario.Text);
            seguridad.lbl_nombreUsuario.Text = LblUsuario.Text;
            seguridad.ShowDialog();
        }

        private void hRMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Area nuevo = new Area(usuarioact);
            nuevo.MdiParent = this.MdiParent;
           nuevo.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Empleados nuevo = new Empleados(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoConcepto nuevo = new TipoConcepto(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void sueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Sueldos nuevo = new Sueldos(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Puestos nuevo = new Puestos(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void planillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetallePlanilla nuevo = new DetallePlanilla(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void generarPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planilla nuevo = new Planilla(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void conceptosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Conceptos nuevo = new Conceptos(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void planillaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bolsaDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
