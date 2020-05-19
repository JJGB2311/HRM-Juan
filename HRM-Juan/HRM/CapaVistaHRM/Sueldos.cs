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
    public partial class Sueldos : Form
    {
        string usuario = "";
        public Sueldos(string user)
        {
            InitializeComponent();
            usuario = user;
            LblUsuario.Text = usuario;
            string[] alias = { "No", "Monto", "Estado" }; // Arreglo de nombres para campos
            navegador1.asignarAlias(alias); // Asignar nombres
            navegador1.asignarSalida(this); // Asignar form de salida
            Color nuevoColor = System.Drawing.ColorTranslator.FromHtml("#ffffff"); // Deficion de 
            navegador1.asignarColorFondo(nuevoColor);
            navegador1.asignarColorFuente(Color.Blue);
            navegador1.asignarAyuda("1"); // asignar 1 por defecto 

            navegador1.asignarTabla("sueldos"); // tabla principal
            navegador1.asignarNombreForm("sueldos"); // Titulo y nombre del form
        }
        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
            }

        }
        private void Sueldos_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            navegador1.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
            progres();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/Ayuda.chm", "Sueldo.html");
        }
    }
}
