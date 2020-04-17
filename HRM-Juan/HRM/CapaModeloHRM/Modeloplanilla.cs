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
        public void nuevoQueryplani(string id ,string idemple,string fehcai,string fechaf )//trasporta el query de la capa de disenio a Datos
        {
            string query = "INSERT INTO `detalle_planilla` (`id_detalle`, `id_planilla`, `id_empleado`, `sueldo_base`, `sueldo_extraordinario`, `total_devengado`, `total_descuento`, `total_liquido`, `estado`) VALUES(NULL, "+id+", "+idemple+", "+ sn.obtenersueldobase(idemple, fehcai, fechaf) + ", " + sn.obtenersueldoextraordinario(idemple, fehcai, fechaf) + ", " + sn.obtenersueldodebengado(idemple, fehcai, fechaf) + ", " + sn.obtenerDescuentos(idemple, fehcai, fechaf) + ",  " + sn.obtenerTotal(idemple, fehcai, fechaf) + ", '1');";
            sn.ejecutarQuerypla(query);
        }
        /**Detalle planilla***/
        public void creardetalle (string id, string fehcai, string fechaf)//trasporta el query de la capa de disenio a Datos
        {

            string[] empleados = sn.obteneridplanilla().Split(',');
            int i=1;
            foreach (var empleado in empleados)
            {
                if (i !=empleados.Length )
                {
                    nuevoQueryplani(id, empleado, fehcai, fechaf);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                }i++;

                Console.WriteLine("---------------------------***********************************************************************************");
            }

        }
       
       
    }
}
