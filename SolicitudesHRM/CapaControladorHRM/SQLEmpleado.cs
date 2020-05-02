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
        public OdbcDataAdapter llenaTbl()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM `empleados` WHERE estado =1 ORDER BY id_empleado DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTblcon(string empeado)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT conceptos.id_empleado,conceptos.fecha_inicio,conceptos.fecha_fin,tipo_concepto.nombre,conceptos.monto,conceptos.debe_Haber FROM conceptos INNER JOIN tipo_concepto ON conceptos.id_tipo = tipo_concepto.id_tipo AND conceptos.estado= 1 AND conceptos.id_empleado="+ empeado + ";";
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
