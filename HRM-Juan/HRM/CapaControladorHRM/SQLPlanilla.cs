using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace CapaControladorHRM
{
    public class SQLPlanilla
    {
        conexionHRM cn = new conexionHRM();
         string planilla = "";
        string IDp ="1";
        /****Planilla***/
        public OdbcDataAdapter llenaTblpla(string tabla)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_planilla,fecha_inicio,fecha_fin,Nombre FROM `planilla` WHERE estado = 1 ORDER BY id_planilla DESC";
          
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public void ejecutarQuerypla(string query)// ejecuta un query en la BD
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (OdbcException ex) { Console.WriteLine(ex.ToString()); }

        }



        /****Detalle de planilla***/
        public void ejecutarQuerydepa(string query)// ejecuta un query en la BD
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (OdbcException ex) { Console.WriteLine(ex.ToString()); }

        }



        public OdbcDataAdapter llenaTblade(string id)// metodo  que obtinene el contenio de una tabla
        {
           

            // string sql = "SELECT id_empleado  FROM empleados WHERE estado=1;";
            string sql = "SELECT detalle_planilla.id_detalle,empleados.nombre,empleados.apellido,detalle_planilla.sueldo_base,detalle_planilla.sueldo_extraordinario,detalle_planilla.total_devengado,detalle_planilla.total_descuento,detalle_planilla.total_liquido FROM `detalle_planilla` INNER JOIN empleados ON empleados.id_empleado = detalle_planilla.id_empleado WHERE detalle_planilla.id_planilla =" + id + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTblade2(string id)// metodo  que obtinene el contenio de una tabla
        {


            // string sql = "SELECT id_empleado  FROM empleados WHERE estado=1;";
            string sql = "SELECT id_planilla,fecha_inicio,fecha_fin,Nombre FROM `planilla` WHERE id_planilla=" + id + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        /**/
        public string obtenerDatodde(string ID)
        {
            string caposactivos1 = "";
            string sql = "SELECT COUNT(detalle_planilla.id_detalle) as dato FROM planilla INNER JOIN detalle_planilla ON planilla.id_planilla = detalle_planilla.id_planilla WHERE detalle_planilla.id_planilla=" + ID + ";";

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
        public string obtenerTOTAL(string ID)
        {
            string caposactivos1 = "";
            string sql = "SELECT COALESCE (round(sum(total_liquido),2),0) FROM `detalle_planilla` WHERE estado=1 AND id_planilla=" + ID + ";";

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

        public string obteneridplanilla()
        {
            string caposactivos1 = ""; 
            string sql = "SELECT id_empleado FROM empleados WHERE estado=1";      
            
            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                caposactivos1 += reader.GetValue(0).ToString()+",";
            }
            caposactivos1.TrimEnd(',');
            return caposactivos1;
        }

        public string obtenersueldobase(string ID)
        {
            string caposactivos2 = "";
            string sql = "SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + ID + ";";

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                caposactivos2 = reader.GetValue(0).ToString();
            }
            return caposactivos2;
        }

        public string obtenersueldoextraordinario(string ID)
        {
            string caposactivos3 = "";
            string sql = "SELECT round( COALESCE (sum(horas.costo * horas.cantidad),0 *(COALESCE ((SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + ID + "),0)/160)),2)+ (SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + ID + ")AS horas FROM horas WHERE id_empleado =" + ID + ";";
            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                caposactivos3 = reader.GetValue(0).ToString();
            }
            return caposactivos3;
        }
        public string obtenersueldodebengado(string ID, string fechaI, string FechaF)
        {
            string caposactivos4 = "";
            string sql = "select ((SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio >= " + fechaI + " AND conceptos.fecha_fin <= " + FechaF + " ) + (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_fin > " + FechaF + ")+ COALESCE((SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + ID + "),0)+(SELECT COALESCE (round(SUM(tipo_comisiones.valor),2),0) FROM empleados INNER JOIN comisiones ON empleados.id_empleado = comisiones.id_empleado INNER JOIN tipo_comisiones ON comisiones.id_tipo_comisiones = tipo_comisiones.id_tipo_comisiones WHERE empleados.id_empleado=" + ID + ")) AS total";
             OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                caposactivos4 = reader.GetValue(0).ToString();
            }
            return caposactivos4;
        }
        public string obtenerDescuentos(string ID, string fechaI, string FechaF)
        {
            string caposactivos5 = "";
            string sql = "select ((SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_inicio >= " + fechaI + " AND conceptos.fecha_fin <= " + FechaF + " ) + (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_fin > " + FechaF + ")) AS total";

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                caposactivos5 = reader.GetValue(0).ToString();
            }
            return caposactivos5;
        }
        public string obtenerTotal(string ID, string fechaI, string FechaF)
        {
            string caposactivos6 = "";
            string sql = "SELECT COALESCE (((SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio >= " + fechaI + " AND conceptos.fecha_fin <= " + FechaF + " ) + (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_fin > " + FechaF + ")+ COALESCE((SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + ID + "),0)+ (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_fin > " + FechaF + ")+ COALESCE((SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + ID + "),0)+(SELECT COALESCE (round(SUM(tipo_comisiones.valor),2),0) FROM empleados INNER JOIN comisiones ON empleados.id_empleado = comisiones.id_empleado INNER JOIN tipo_comisiones ON comisiones.id_tipo_comisiones = tipo_comisiones.id_tipo_comisiones WHERE empleados.id_empleado=" + ID + ")),0)-COALESCE (((SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_inicio >= " + fechaI + " AND conceptos.fecha_fin <= " + FechaF + " ) + (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_fin > " + FechaF + ")),0)  AS total";

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                caposactivos6 = reader.GetValue(0).ToString();
            }
            return caposactivos6;
        }
    }
}
