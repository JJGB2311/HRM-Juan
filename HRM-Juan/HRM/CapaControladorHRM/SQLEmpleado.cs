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
        /*recontra*/
        public OdbcDataAdapter llenaTbl2()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM `empleados` WHERE estado =2 ORDER BY id_empleado DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        /**/
        public OdbcDataAdapter llenaTblcon(string empeado)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT conceptos.id_empleado,conceptos.fecha_inicio,conceptos.fecha_fin,tipo_concepto.nombre,conceptos.monto,conceptos.debe_Haber FROM conceptos INNER JOIN tipo_concepto ON conceptos.id_tipo = tipo_concepto.id_tipo AND conceptos.estado= 1 AND conceptos.id_empleado="+ empeado + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenaTblcon2(string empeado)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT conceptos.id_concepto, conceptos.id_empleado,conceptos.fecha_inicio,conceptos.fecha_fin,tipo_concepto.nombre,conceptos.monto,conceptos.debe_Haber FROM conceptos INNER JOIN tipo_concepto ON conceptos.id_tipo = tipo_concepto.id_tipo AND conceptos.estado= 1 AND conceptos.id_empleado=" + empeado + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /*Busquedas*/
        public OdbcDataAdapter llenaTblcod(string empeado)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM `empleados` WHERE estado =1 AND id_empleado=" + empeado + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTblnomap(string nombre,string apellido)// metodo  que obtinene el contenio de una tabla
        {
            
            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM `empleados` WHERE estado =1 AND nombre= '"+nombre+"' OR apellido = '"+apellido+"';";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /**/
        /*Busquedas2*/
        public OdbcDataAdapter llenaTblcod2(string empeado)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM `empleados` WHERE estado =2 AND id_empleado=" + empeado + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTblnomap2(string nombre, string apellido)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM `empleados` WHERE estado =2 AND nombre= '" + nombre + "' OR apellido = '" + apellido + "';";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /**/

        public OdbcDataAdapter llenaTblempleno(string empeado)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT conceptos.id_empleado,conceptos.fecha_inicio,conceptos.fecha_fin,tipo_concepto.nombre,conceptos.monto,conceptos.debe_Haber FROM conceptos INNER JOIN tipo_concepto ON conceptos.id_tipo = tipo_concepto.id_tipo AND conceptos.estado= 1 AND conceptos.id_empleado=" + empeado + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenaTblemplenom(string empeado)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT conceptos.id_empleado,conceptos.fecha_inicio,conceptos.fecha_fin,tipo_concepto.nombre,conceptos.monto,conceptos.debe_Haber FROM conceptos INNER JOIN tipo_concepto ON conceptos.id_tipo = tipo_concepto.id_tipo AND conceptos.estado= 1 AND conceptos.id_empleado=" + empeado + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        /*Despidos*/
        public OdbcDataAdapter llenaTbldes()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM `empleados` WHERE estado =2 ORDER BY id_empleado DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        /*finiquitos*/
        public OdbcDataAdapter llenaTblfin()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_finiqito,id_empleados,motivo,descripcion,total_prestaciones FROM finiqito WHERE estado=1 ORDER BY id_finiqito DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /**/
        public string obtenerEMP()
        {
            string caposactivos1 = "";
            string sql = "select MAX(id_empleado) from empleados where estado=1;";

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                caposactivos1 += reader.GetValue(0).ToString();
            }
            caposactivos1.TrimEnd(',');
            return caposactivos1;
        }
        /**/
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
