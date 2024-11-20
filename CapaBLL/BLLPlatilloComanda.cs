using CapaDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaBLL
{
    public class BLLPlatilloComanda
    {
        //Insertar Platillo Comanda
        public static void InsertarPlatilloComanda(int platillo_id, int comanda_id, int cantidad, string extras)
        {
            try
            {
                DALPlatilloComanda.InsertarPlatilloComanda(platillo_id, comanda_id, cantidad, extras);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Listar Platillo Comanda
        public static List<PlatilloComandaVO> GetListPlatilloComanda()
        {
            List<PlatilloComandaVO> list = DALPlatilloComanda.GetListPlatilloComanda();

            return list;
            
        }

        //Actualizar Platillo Comanda
        public static void ActualizarPlatilloComanda(int platillo_id, int comanda_id, int cantidad, string extras)
        {
            try
            {
                DALPlatilloComanda.ActualizarPlatilloComanda(platillo_id, comanda_id, cantidad, extras);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Eliminar Platillo Comanda
        public static void EliminarPlatilloComanda(int id_platillocomanda)
        {
            try
            {
                DALPlatilloComanda.EliminarPlatilloComanda(id_platillocomanda);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Obtener Platillo Comanda por ID
        public static PlatilloComandaVO GetPedidoPlatilloComandaById(int id_platillocomanda)
        {
            try
            {
                return DALPlatilloComanda.GetPedidoPlatilloComandaById(id_platillocomanda);

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
