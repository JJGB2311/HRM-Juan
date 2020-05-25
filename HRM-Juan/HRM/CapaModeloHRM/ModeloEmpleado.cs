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
        /*recontra*/
        public DataTable consultaLogica2()
        {
            OdbcDataAdapter dt = sn.llenaTbl2();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /**/
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
        /*Busqueda2*/
        public DataTable consultaLogicacod2(string emple)
        {
            OdbcDataAdapter dt = sn.llenaTblcod2(emple);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogicanoma2(string nombre, string apelldo)
        {
            OdbcDataAdapter dt = sn.llenaTblnomap2(nombre, apelldo);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /**/
        /*des*/
        public DataTable consultaLogicades()
        {
            OdbcDataAdapter dt = sn.llenaTbldes();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /*fini*/
        public DataTable consultaLogicafini()
        {
            OdbcDataAdapter dt = sn.llenaTblfin();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /**/
        /*solicitud*/
        public DataTable consultaLogisoli()
        {
            OdbcDataAdapter dt = sn.llenaTblsoli();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /**/
        /*solicitudp*/
        public DataTable consultaLogisolip()
        {
            OdbcDataAdapter dt = sn.llenaTblsolip();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /**/
        public string nuevoEMPCON()//trasporta el query de la capa de disenio a Datos
        {
            return sn.obtenerEMP();
        }

         public string nuevoEMPCONSU()//trasporta el query de la capa de disenio a Datos
        {
            return sn.obtenerEMPSU();
        }
        public DataTable consultaLogiemplecod(string emple)
        {
            OdbcDataAdapter dt = sn.llenaTblempleno(emple);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /*emple*/
        public DataTable consultaLogiENP()
        {
            OdbcDataAdapter dt = sn.llenaTblen();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /**/
        public DataTable llenaTblemplenom(string emple)
        {
            OdbcDataAdapter dt = sn.llenaTblcon(emple);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /*perfil*/
        public DataTable consultaLogicap()
        {
            OdbcDataAdapter dt = sn.llenaTblp();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        /**/
        public void nuevoQuery(String query)//trasporta el query de la capa de disenio a Datos
        {
            sn.ejecutarQuery(query);
        }
    }
}
