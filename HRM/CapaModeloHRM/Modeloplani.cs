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
   public class Modeloplani
    {
        sentenciaplani sn = new sentenciaplani();
        public DataTable consultaLogica(string tabla)
        {
            OdbcDataAdapter dt = sn.llenaTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

    }
}
