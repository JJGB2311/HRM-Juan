using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaHRM
{
    public partial class GenePlanilla : Form
    {
        string user;
        string dato;
        string fechain;
        string fechafi;
        public GenePlanilla(string usuario , string id,string fechai,string fechaf)
        {
            InitializeComponent();
            user = usuario;
            dato = id;
            fechain = fechai;
            fechafi = fechaf;
            LblUsuario.Text = usuario;
            Lbl_planinlla.Text = dato;
            Lbl_fechai.Text = fechain;
            Lbl_fechaf.Text = fechafi;
        }

        private void GenePlanilla_Load(object sender, EventArgs e)
        {

        }
    }
}
