using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALPlatilloComanda
    {
        //Insertar Platillo Comanda
        public static void InsertarPlatilloComanda(int platillo_id, int comanda_id, int cantidad, string extras)
        {
            try
            { 
                MetodoDatos.ExecuteNonQuery("sp_InsertarPlatilloComanda","@Platillo_ID", platillo_id, "@Comanda_ID", comanda_id, "@Cantidad", cantidad, "@Extras", extras);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Listar Platillo Comanda
        public static List<PlatilloComandaVO> GetListPlatilloComanda()
        {
            List<PlatilloComandaVO> list = new List<PlatilloComandaVO>();
            try
            {
                DataSet dsPC = MetodoDatos.ExecuteDataSet("sp_ListarPlatilloComanda");

                foreach (DataRow dr in dsPC.Tables[0].Rows)
                {
                    list.Add(new PlatilloComandaVO(dr));
                }

                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Actualizar Platillo Comanda
        public static void ActualizarPlatilloComanda(int platillo_id, int comanda_id, int cantidad, string extras)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_ActualizarPlatilloComanda", "@Platillo_ID", platillo_id, "@Comanda_ID", comanda_id, "@Cantidad", cantidad, "@Extras", extras);
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
                MetodoDatos.ExecuteNonQuery("sp_EliminaPlatilloComanda", "@ID_PlatilloComanda", id_platillocomanda);
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
                DataSet dsPS = MetodoDatos.ExecuteDataSet("sp_ObtenerPlatilloComandaPorID", "@ID_PlatilloComanda", id_platillocomanda);
                if (dsPS.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsPS.Tables[0].Rows[0];
                    return new PlatilloComandaVO(dr);
                }
                else
                {
                    return new PlatilloComandaVO();
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
