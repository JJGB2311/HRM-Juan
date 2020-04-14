using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using CapaControladorHRM;
using System.Data;

namespace CapaModeloHRM
{
   public class Modeloplanilla
    {
        SQLPlanilla sn = new SQLPlanilla();
        public DataTable consultaLogicaplani(string tabla)
        {
            OdbcDataAdapter dt = sn.llenaTblpla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void nuevoQueryplani(String query)//trasporta el query de la capa de disenio a Datos
        {
            sn.ejecutarQuerypla(query);
        }
    }
}
