using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class DatosPedidoVO
    {
        private int _ID_PedidoDomicilio;
        private string _Pedido;
        private DateTime _Fecha;
        private DateTime _HoraPedido;
        private DateTime _HoraEnvio;
        private DateTime _HoraEntrega;

        public int ID_PedidoDomicilio { get => _ID_PedidoDomicilio; set => _ID_PedidoDomicilio = value; }
        public string Pedido { get => _Pedido; set => _Pedido = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public DateTime HoraPedido { get => _HoraPedido; set => _HoraPedido = value; }
        public DateTime HoraEnvio { get => _HoraEnvio; set => _HoraEnvio = value; }
        public DateTime HoraEntrega { get => _HoraEntrega; set => _HoraEntrega = value; }

        public DatosPedidoVO()
        {
            ID_PedidoDomicilio = 0;
            Pedido = string.Empty;
            Fecha = DateTime.Parse("1990-01-01");
            HoraPedido = DateTime.Parse("00:00:00");
            HoraEnvio = DateTime.Parse("00:00:00");
            HoraEntrega = DateTime.Parse("00:00:00");
        }
        public DatosPedidoVO(PedidoDomicilioVO pd, List<PlatilloVO> lp, int[] cant)
        {
            ID_PedidoDomicilio = pd.ID_PedidoDomicilio;
            Pedido = "";
            Fecha = pd.Fecha;
            HoraPedido = pd.HoraPedido;
            HoraEnvio = pd.HoraEnvio;
            HoraEntrega = pd.HoraEntrega;
            int i = 0;
            foreach(PlatilloVO p in lp)
            {
                Pedido += cant[i] + " de " + p.Nombre + ", ";
                i++;
            }
        }
    }
}
