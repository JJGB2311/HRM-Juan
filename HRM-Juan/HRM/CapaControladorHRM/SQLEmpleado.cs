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

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM empleados WHERE estado =1 ORDER BY id_empleado DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /*recontra*/
        public OdbcDataAdapter llenaTbl2()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM empleados WHERE estado =2 ORDER BY id_empleado DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        /**/
        /*perfil*/
        public OdbcDataAdapter llenaTblp()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_perfil,nombre,educacion,nivel,descripcion FROM `perfiles` WHERE estado=1 ORDER BY id_perfil DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        /**/
        /*empleo*/
        public OdbcDataAdapter llenaTblen()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT empleos.id_empleos,empleos.id_solicitud,sueldos.salario,empleos.detalles,empleos.fecha,empleos.tipo FROM empleos INNER JOIN sueldos ON sueldos.id_sueldo = empleos.id_sueldo WHERE empleos.estado =1 ORDER by empleos.id_empleos DESC;";
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

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM empleados WHERE estado =1 AND id_empleado=" + empeado + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTblnomap(string nombre,string apellido)// metodo  que obtinene el contenio de una tabla
        {
            
            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM empleados WHERE estado =1 AND nombre= '"+nombre+"' OR apellido = '"+apellido+"';";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /**/
        /*Busquedas2*/
        public OdbcDataAdapter llenaTblcod2(string empeado)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM empleados WHERE estado =2 AND id_empleado=" + empeado + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTblnomap2(string nombre, string apellido)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM empleados WHERE estado =2 AND nombre= '" + nombre + "' OR apellido = '" + apellido + "';";
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

            string sql = "SELECT id_empleado,nombre,apellido,sexo,fecha_de_nacimiento,cui,correo,id_puesto,id_area,nit,direccion FROM empleados WHERE estado =2 ORDER BY id_empleado DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /*Soli*/
        public OdbcDataAdapter llenaTblsoli()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT solicitudes.id_solicitud,perfiles.nombre AS perfile,area.nombre AS area ,solicitudes.fecha,solicitudes.detalles,solicitudes.Cantidad,solicitudes.motivo,puestos.nombre AS puestos FROM solicitudes INNER JOIN perfiles ON perfiles.id_perfil = solicitudes.id_perfil INNER JOIN area ON area.id_area = solicitudes.id_area INNER JOIN puestos ON puestos.id_puesto = solicitudes.id_puesto WHERE solicitudes.estado=1 ORDER by solicitudes.id_solicitud DESC;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /*Solip*/
        public OdbcDataAdapter llenaTblsolip()// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT solicitudes.id_solicitud,perfiles.nombre AS perfile,area.nombre AS area ,solicitudes.fecha,solicitudes.detalles,solicitudes.Cantidad,solicitudes.motivo,puestos.nombre AS puestos FROM solicitudes INNER JOIN perfiles ON perfiles.id_perfil = solicitudes.id_perfil INNER JOIN area ON area.id_area = solicitudes.id_area INNER JOIN puestos ON puestos.id_puesto = solicitudes.id_puesto WHERE solicitudes.estado=2 ORDER by solicitudes.id_solicitud DESC;";
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
        /**/
        public string obtenerEMPSU()
        {
            string caposactivos1 = "";
            string sql = "SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =(select MAX(id_empleado) from empleados where estado=1);";

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
