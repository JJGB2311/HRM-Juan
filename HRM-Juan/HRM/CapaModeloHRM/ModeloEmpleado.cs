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
        public DataTable consultaLogicacon2(string emple)
        {
            OdbcDataAdapter dt = sn.llenaTblcon2(emple);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /*Busqueda*/
        public DataTable consultaLogicacod(string emple)
        {
            OdbcDataAdapter dt = sn.llenaTblcod(emple);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogicanoma(string nombre,string apelldo)
        {
            OdbcDataAdapter dt = sn.llenaTblnomap(nombre,apelldo);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /**/
        public string nuevoEMPCON()//trasporta el query de la capa de disenio a Datos
        {
            return sn.obtenerEMP();
        }

        public DataTable consultaLogiemplecod(string emple)
        {
            OdbcDataAdapter dt = sn.llenaTblempleno(emple);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable llenaTblemplenom(string emple)
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
