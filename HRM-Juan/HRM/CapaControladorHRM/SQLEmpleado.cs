using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaControladorHRM
{
  
    public class SQLEmpleado
    {
        conexionHRM cn = new conexionHRM();
        public OdbcDataAdapter llenaTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT * FROM `empleados` WHERE 1";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public void ejecutarQuery(string query)// ejecuta un query en la BD
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (OdbcException ex) { Console.WriteLine(ex.ToString()); }

        }
    }
}
