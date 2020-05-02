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
   public class Modeloplanilla
    {
        SQLPlanilla sn = new SQLPlanilla();
        public DataTable consultaLogicaplani(string tabla)
        {
            OdbcDataAdapter dt = sn.llenaTblpla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable consultaLogicadet(string tabla)
        {
            OdbcDataAdapter dt = sn.llenaTblade(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void nuevoQuerypla(String query)//trasporta el query de la capa de disenio a Datos
        {
            sn.ejecutarQuerypla(query);
        }
        public DataTable consultaLogicadet2(string tabla)
        {
            OdbcDataAdapter dt = sn.llenaTblade2(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void nuevoQuerydepla(String query)//trasporta el query de la capa de disenio a Datos
        {
            sn.ejecutarQuerydepa(query);
        }
        public string nuevovali(string IDv)//trasporta el query de la capa de disenio a Datos
        {
           return sn.obtenerDatodde(IDv);
        }
        public string Totalpla(string IDv)//trasporta el query de la capa de disenio a Datos
        {
            return sn.obtenerTOTAL(IDv);
        }

        public void nuevoQueryplani(int IDDE ,string IDPL ,string IDEMPLE,string fehcai,string fechaf )//trasporta el query de la capa de disenio a Datos
        {
                     
                string query = "INSERT INTO `detalle_planilla` (`id_detalle`, `id_planilla`, `id_empleado`, `sueldo_base`, `sueldo_extraordinario`, `total_devengado`, `total_descuento`, `total_liquido`, `estado`) VALUES ('" + IDDE + "', '" + IDPL + "', '" + IDEMPLE + "','" + sn.obtenersueldobase(IDEMPLE) + "', '" + sn.obtenersueldoextraordinario(IDEMPLE) + "', '" + sn.obtenersueldodebengado(IDEMPLE, fehcai, fechaf) + "', '" + sn.obtenerDescuentos(IDEMPLE, fehcai, fechaf) + "', '" + sn.obtenerTotal(IDEMPLE, fehcai, fechaf) + "', '1');";

                sn.ejecutarQuerypla(query);
               
        }
        /**Detalle planilla***/
        public void creardetalle (string IDPL, string fechai, string fechaf)//trasporta el query de la capa de disenio a Datos
        {

            string[] empleados = sn.obteneridplanilla().Split(',');
            int i=1;
            int cont = 1;
          
            foreach (var empleado in empleados)
            { 
                if (i !=empleados.Length )
                { 
                   
                    nuevoQueryplani(cont, IDPL, empleado, fechai, fechaf);
                 //   Console.WriteLine(sn.obtenerTotal(empleado, fechai, fechaf) + "---------------------------------------------------------------------------------------------------------");
                }i++;
                cont++;

               // Console.WriteLine("---------------------------***********************************************************************************");
            }

        }
       
       
    }
}
