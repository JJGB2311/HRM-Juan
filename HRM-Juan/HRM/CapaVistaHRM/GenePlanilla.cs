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
    public partial class GenePlanilla : Form
    {
        Modeloplanilla logic = new Modeloplanilla();
        string user;
        string dato;
        
      
        public GenePlanilla(string usuario , string IDpla)
        {
            InitializeComponent();
            user = usuario;
            dato = IDpla;
            LblUsuario.Text = usuario;
            Lbl_planinlla.Text = dato;
                
            Mostrarpla();
            Mostrarpla2();
        }
        void Mostrarpla()
        {

            DataTable dt = logic.consultaLogicadet(dato);
            dataGridView1.DataSource = dt;
        }
        void Mostrarpla2()
        {

            DataTable dt = logic.consultaLogicadet2(dato);
            dataGridView2.DataSource = dt;
        }
        private void GenePlanilla_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Planilla nuevo = new Planilla(user);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }
    }
}
