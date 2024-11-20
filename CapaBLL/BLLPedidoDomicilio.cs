using CapaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaBLL
{
    public class BLLPedidoDomicilio
    {
        //Insertar Pedido Domicilio
        public static void InsertarPedidoDomicilio(DateTime fecha, DateTime horaPedido, DateTime horaEnvio, DateTime horaEntrega)
        {
            try
            {
                DALPedidoDomicilio.InsertarPedidoDomicilio(fecha, horaPedido, horaEnvio, horaEntrega);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Listar Pedido Domicilio
        public static List<PedidoDomicilioVO> GetListPedidoDomicilio()
        {
            try
            {
                return DALPedidoDomicilio.GetListPedidoDomicilio();
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
                DALPedidoDomicilio.ActualizarPedidoDomicilio(id_pedidodomicilio, fecha, horaPedido, horaEnvio, horaEntrega);
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
                DALPedidoDomicilio.EliminarPedidoDomicilio(id_pedidodomicilio);
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
                return DALPedidoDomicilio.GetPedidoDomicilioById(id_pedidodomicilio);

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
