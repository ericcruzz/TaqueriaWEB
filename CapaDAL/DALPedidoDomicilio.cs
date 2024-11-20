using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALPedidoDomicilio
    {
        //Insertar Pedido Domicilio
        public static void InsertarPedidoDomicilio(DateTime fecha, DateTime horaPedido, DateTime horaEnvio, DateTime horaEntrega)
        {
            try
            {                
                MetodoDatos.ExecuteNonQuery("sp_InsertarPedidoDomicilio", "@Fecha", fecha, "@HoraPedido", horaPedido, "@HoraEnvio", horaEnvio, "@HoraEntrega", horaEntrega);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Listar Pedido Domicilio
        public static List<PedidoDomicilioVO> GetListPedidoDomicilio()
        {
            List<PedidoDomicilioVO> list = new List<PedidoDomicilioVO>();
            try
            {
                DataSet dsPD = MetodoDatos.ExecuteDataSet("sp_ListarPedidoDomicilio");

                foreach (DataRow dr in dsPD.Tables[0].Rows)
                {
                    list.Add(new PedidoDomicilioVO(dr));
                }

                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Actualizar Pedido Domicilio
        public static void ActualizarPedidoDomicilio(int id_pedidodomicilio, DateTime fecha, DateTime horaPedido, DateTime horaEnvio, DateTime horaEntrega)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_ActualizarPedidoDomicilio", "@ID_PedidoDomicilio", id_pedidodomicilio, "@Fecha", fecha, "@HoraPedido", horaPedido, "@HoraEnvio", horaEnvio, "@HoraEntrega", horaEntrega);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Eliminar Pedido Domicilio
        public static void EliminarPedidoDomicilio(int id_pedidodomicilio)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_EliminaPedidoDomicilio", "@ID_PedidoDomicilio", id_pedidodomicilio);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Obtener Pedido Domicilio por ID
        public static PedidoDomicilioVO GetPedidoDomicilioById(int id_pedidodomicilio)
        {
            try
            {
                DataSet dsPS = MetodoDatos.ExecuteDataSet("sp_ObtenerPedidoDomicilioPorID", "@ID_PedidoDomicilio", id_pedidodomicilio);
                if (dsPS.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsPS.Tables[0].Rows[0];
                    return new PedidoDomicilioVO(dr);
                }
                else
                {
                    return new PedidoDomicilioVO();
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
