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
    public class BLLComanda
    {
        //Insertar Comanda
        public static void InsertarComanda(int cliente_id, int pedidoDomicilio_id)
        {
            try
            {
                DALComanda.InsertarComanda(cliente_id, pedidoDomicilio_id);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Listar Comanda
        public static List<ComandaVO> GetListComandas()
        {
            List<ComandaVO> list = DALComanda.GetListComandas();

            return list;

        }
            

        //Actualizar Comanda
        public static void ActualizarComanda(int id_comanda, int cliente_id, int pedidoDomicilio_id)
        {
            try
            {
                BLLComanda.ActualizarComanda( id_comanda, cliente_id, pedidoDomicilio_id);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Eliminar Comanda
        public static void EliminarComanda(int id_comanda)
        {
            try
            {
                DALComanda.EliminarComanda(id_comanda);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Obtener Comanda por ID
        public static ComandaVO GetComandaById(int id_comanda)
        {
            try
            {
                return DALComanda.GetComandaById(id_comanda);

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
