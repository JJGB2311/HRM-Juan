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
    public partial class Perfiles : Form
    {
        ModeloEmpleado logic = new ModeloEmpleado();
        string usuario = "";
        string dato;
        public Perfiles(string user ,string num)
        {
            InitializeComponent();
            usuario = user;
            dato = num;
            LblUsuario.Text = usuario;
             Mostraremp();
            CBO_Nivel.Items.Add("Posgrados");
            CBO_Nivel.Items.Add("Universitaria");
            CBO_Nivel.Items.Add("Divercificado");
            CBO_Nivel.Items.Add("Basico");
            CBO_Nivel.Items.Add("Primaria");
       


        }
        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
            }

        }
        string crearInsert()// crea el query de insert
        {
           
            string query = "INSERT INTO `perfiles` (`id_perfil`, `nombre`, `educacion`, `nivel`, `descripcion`, `estado`) VALUES (NULL, '"+txt_Nombre.Text+"', '" + CBO_Nivel.Text+ "', '"+ TXT_carrera.Text+ "', '"+Txt_descripcion.Text+"', '1');";

            return query;
        }
        string crearUpdate()// crea el query de insert
        {
           
            string query = "UPDATE `perfiles` SET `nombre` = '"+txt_Nombre.Text+"', `educacion` = '"+CBO_Nivel.Text+"', `nivel` = '"+TXT_carrera.Text+"', `descripcion` = '"+Txt_descripcion.Text+"' WHERE `perfiles`.`id_perfil` = "+txt_No.Text+";";

            return query;
        }
        string crearDelete()// crea el query de insert
        {
           
            string query = "UPDATE `perfiles` SET `estado` = '0' WHERE `perfiles`.`id_perfil` = " + txt_No.Text + ";";

            return query;
        }
        void Mostraremp()
        {
            DataTable dt = logic.consultaLogicap();
            dataGridView1.DataSource = dt;
        }
        private void Perfiles_Load(object sender, EventArgs e)
        {
           
            progres();
        }

        private void BTN_nuevo_Click(object sender, EventArgs e)
        {
            BTN_Guardar.Enabled = true;
            txt_No.Text = "";
            txt_Nombre.Text = "";
            Txt_descripcion.Text = "";
            TXT_carrera.Text = "";
            CBO_Nivel.Text = "";
            BTN_CANCEL.Enabled = true;
            txt_Nombre.Enabled = true;
            CBO_Nivel.Enabled = true;
            Txt_descripcion.Enabled = true;
            BTN_nuevo.Enabled = true;
            TXT_carrera.Enabled = true;
            progres();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txt_No.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                CBO_Nivel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TXT_carrera.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Txt_descripcion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_Nombre.Enabled = true;
                CBO_Nivel.Enabled = true;
                TXT_carrera.Enabled = true;
                Txt_descripcion.Enabled = true;
                BTN_CANCEL.Enabled = true;

                if (dato == "1")
                {
                    BTN_ELIMI.Enabled = true;
                    BTN_Modifi.Enabled = true;
                }
                else {
                    BTN_ELIMI.Enabled = false;
                    BTN_Modifi.Enabled = false;
                }
             

                progres();

            
            }
            else
            {
                MessageBox.Show("Seleccione un Registro!", "Planilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearInsert());
            Mostraremp();
            BTN_Guardar.Enabled = false;
            txt_No.Text = "";
            txt_Nombre.Text = "";
            Txt_descripcion.Text = "";
            TXT_carrera.Text = "";
            CBO_Nivel.Text = "";
            BTN_CANCEL.Enabled = false;
            BTN_nuevo.Enabled = true;
            BTN_nuevo.Enabled = true;
            TXT_carrera.Enabled = true;
            txt_Nombre.Enabled = false;
            BTN_nuevo.Enabled = false;
            TXT_carrera.Enabled = false;
            Txt_descripcion.Enabled = false;
            progres();
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Mostraremp();
            BTN_nuevo.Enabled = true;
            BTN_Modifi.Enabled = false;
            BTN_ELIMI.Enabled = false;
            BTN_Guardar.Enabled = false;
            txt_No.Text = "";
            txt_Nombre.Text = "";
            Txt_descripcion.Text = "";
        
            TXT_carrera.Text = "";
            txt_Nombre.Enabled = false;
            TXT_carrera.Enabled = false;
            Txt_descripcion.Enabled = false;
            CBO_Nivel.Enabled = false;
            BTN_CANCEL.Enabled = false;
            BTN_nuevo.Enabled = false;
            TXT_carrera.Enabled = false;
            CBO_Nivel.Text = "--Selecione--";
            progres();
        }

        private void BTN_Modifi_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearUpdate());
            Mostraremp();
            BTN_Guardar.Enabled = false;
            txt_No.Text = "";
            txt_Nombre.Text = "";
            Txt_descripcion.Text = "";
            TXT_carrera.Text = "";
            CBO_Nivel.Text = "";
            BTN_CANCEL.Enabled = false;
            BTN_nuevo.Enabled = true;
            BTN_nuevo.Enabled = true;
            TXT_carrera.Enabled = true;
            txt_Nombre.Enabled = false;
            BTN_nuevo.Enabled = false;
            TXT_carrera.Enabled = false;
            Txt_descripcion.Enabled = false;
            CBO_Nivel.Enabled = false;
            BTN_Modifi.Enabled = false;
            BTN_ELIMI.Enabled = false;
            BTN_nuevo.Enabled = true;
            progres();
        }

        private void BTN_ELIMI_Click(object sender, EventArgs e)
        {
            logic.nuevoQuery(crearDelete());
            Mostraremp();
            BTN_Guardar.Enabled = false;
            txt_No.Text = "";
            txt_Nombre.Text = "";
            Txt_descripcion.Text = "";
            TXT_carrera.Text = "";
            CBO_Nivel.Text = "";
            txt_No.Text = "";
            txt_Nombre.Text = "";
            Txt_descripcion.Text = "";
            TXT_carrera.Text = "";
            CBO_Nivel.Text = "";
            BTN_CANCEL.Enabled = false;
            BTN_nuevo.Enabled = true;
            BTN_nuevo.Enabled = true;
            TXT_carrera.Enabled = true;
            txt_Nombre.Enabled = false;
            BTN_nuevo.Enabled = false;
            TXT_carrera.Enabled = false;
            CBO_Nivel.Enabled = false;
            Txt_descripcion.Enabled = false;
            BTN_Modifi.Enabled = false;
            BTN_ELIMI.Enabled = false;
            BTN_nuevo.Enabled = true;
            progres();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "Perfiles.html");
        }
    }
}
