using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALComanda
    {
        //Insertar Comanda
        public static void InsertarComanda(int cliente_id, int pedidoDomicilio_id)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_InsertaComanda", "@Cliente_ID", cliente_id, "@PedidoDomicilio_ID", pedidoDomicilio_id);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Listar Comanda
        public static List<ComandaVO> GetListComandas()
        {
            List<ComandaVO> list = new List<ComandaVO>();
            try
            {
                DataSet dscomandas = MetodoDatos.ExecuteDataSet("sp_ListarComandas");

                foreach (DataRow dr in dscomandas.Tables[0].Rows)
                {
                    list.Add(new ComandaVO(dr));
                }

                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Actualizar Comanda
        public static void ActualizarComanda(int id_comanda, int cliente_id, int pedidoDomicilio_id)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_ActualizarComanda", "@ID_Comanda", id_comanda, "@Cliente_ID", cliente_id, "@PedidoDomicilio_ID", pedidoDomicilio_id);
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
                MetodoDatos.ExecuteNonQuery("sp_EliminaComanda", false, "@ID_Comanda", id_comanda);
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
                DataSet dsComanda = MetodoDatos.ExecuteDataSet("sp_ObtenerComandaPorID", "@ID_Comanda", id_comanda);
                if (dsComanda.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsComanda.Tables[0].Rows[0];
                    return new ComandaVO(dr);
                }
                else
                {
                    return new ComandaVO();
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
