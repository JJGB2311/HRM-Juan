﻿using System;
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
    public partial class Puestos : Form
    {
        string usuario = "";
        public Puestos(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "No", "Nombre","Sueldo", "Estado" }; // Arreglo de nombres para campos
            navegador1.asignarAlias(alias); // Asignar nombres
            navegador1.asignarSalida(this); // Asignar form de salida
            Color nuevoColor = System.Drawing.ColorTranslator.FromHtml("#0926E3"); // Deficion de 
            navegador1.asignarColorFondo(nuevoColor);
            navegador1.asignarColorFuente(Color.White);
            navegador1.asignarAyuda("1"); // asignar 1 por defecto 
            // LOS COMBOS SE ASIGNAN SEGUN EL ORDEN EN QUE SE DECLAREN
            navegador1.asignarComboConTabla("sueldos", "salario", 2); // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id
            navegador1.asignarTabla("puestos"); // tabla principal
            navegador1.asignarNombreForm("Puestos"); // Titulo y nombre del form
        }

        private void Puestos_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            navegador1.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
        }
    }
}
