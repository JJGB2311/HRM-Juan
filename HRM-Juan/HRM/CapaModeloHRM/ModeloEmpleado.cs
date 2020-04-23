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
   public class ModeloEmpleado
    {

        SQLEmpleado sn = new SQLEmpleado();
        public DataTable consultaLogica()
        {
            OdbcDataAdapter dt = sn.llenaTbl();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogicacon(string emple)
        {
            OdbcDataAdapter dt = sn.llenaTblcon(emple);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void nuevoQuery(String query)//trasporta el query de la capa de disenio a Datos
        {
            sn.ejecutarQuery(query);
        }
    }
}
