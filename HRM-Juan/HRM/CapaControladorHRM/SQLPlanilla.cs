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
        string ID = "1";
       string fechaI ="2020-04-01" ;
       string FechaF = "2020-04-30";
        string idpla = "1";
        string planilla = "";
        /****Planilla***/
        public OdbcDataAdapter llenaTblpla(string tabla)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT id_planilla,fecha_inicio,fecha_fin,Nombre FROM `planilla` WHERE estado =1";
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
        public OdbcDataAdapter llenaTblade(string ID)// metodo  que obtinene el contenio de una tabla
        {


            string sql = "SELECT id_planilla,fecha_inicio,fecha_fin,Nombre FROM `planilla` WHERE estado =1";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

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

        public string obtenersueldobase(string idpla , string fechaI, string FechaF)
        {
            string caposactivos2 = "";
            string sql = "SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + idpla + ";";
            
            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
           
             caposactivos2 = reader.GetValue(0).ToString() ;
            
            return caposactivos2;
        }

        public string obtenersueldoextraordinario(string idpla, string fechaI, string FechaF)
        {
            string caposactivos3 = "";
            string sql = "SELECT round( sum(horas.costo * horas.cantidad *((SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + idpla + ")/160)),2)+ (SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + idpla + ")AS horas FROM horas WHERE id_empleado =" + idpla + "";
         
            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            caposactivos3 = reader.GetValue(0).ToString();
            return caposactivos3;
        }
        public string obtenersueldodebengado(string idpla, string fechaI, string FechaF)
        {
            string caposactivos4 = "";
            string sql = "select ((SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + idpla + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio >= " + fechaI + " AND conceptos.fecha_fin <= " + FechaF + " ) + (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + idpla + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + idpla + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_fin > " + FechaF + ")+ COALESCE((SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + idpla + "),0)) AS total";
             OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            caposactivos4 = reader.GetValue(0).ToString();
            return caposactivos4;
        }
        public string obtenerDescuentos(string ID, string fechaI, string FechaF)
        {
            string caposactivos5 = "";
            string sql = "select ((SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_inicio >= " + fechaI + " AND conceptos.fecha_fin <= " + FechaF + " ) + (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_fin > " + FechaF + ")) AS total";

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            caposactivos5 = reader.GetValue(0).ToString();
            return caposactivos5;
        }
        public string obtenerTotal(string ID, string fechaI, string FechaF)
        {
            string caposactivos6 = "";
            string sql = "SELECT COALESCE (((SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio >= " + fechaI + " AND conceptos.fecha_fin <= " + FechaF + " ) + (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =1 AND conceptos.fecha_fin > " + FechaF + ")+ COALESCE((SELECT sueldos.salario FROM empleados INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo WHERE empleados.id_empleado =" + ID + "),0)),0)-COALESCE (((SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_inicio >= " + fechaI + " AND conceptos.fecha_fin <= " + FechaF + " ) + (SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_inicio = 1111 - 11 - 11 AND conceptos.fecha_fin = 1111 - 11 - 11)+(SELECT COALESCE (round(sum(conceptos.monto),2),0) FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado WHERE empleados.id_empleado =" + ID + " AND conceptos.estado =1 AND conceptos.debe_Haber =0 AND conceptos.fecha_fin > " + FechaF + ")),0)  AS total";

            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataReader reader = command.ExecuteReader();
            caposactivos6 = reader.GetValue(0).ToString();
            return caposactivos6;
        }
    }
}
