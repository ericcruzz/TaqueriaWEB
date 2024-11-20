using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class PedidoDomicilioVO
    {
        private int _ID_PedidoDomicilio;
        private DateTime _Fecha;
        private DateTime _HoraPedido;
        private DateTime _HoraEnvio;
        private DateTime _HoraEntrega;

        public int ID_PedidoDomicilio { get => _ID_PedidoDomicilio; set => _ID_PedidoDomicilio = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public DateTime HoraPedido { get => _HoraPedido; set => _HoraPedido = value; }
        public DateTime HoraEnvio { get => _HoraEnvio; set => _HoraEnvio = value; }
        public DateTime HoraEntrega { get => _HoraEntrega; set => _HoraEntrega = value; }

        public PedidoDomicilioVO()
        {
            ID_PedidoDomicilio = 0;
            Fecha = DateTime.Parse("1990-01-01");
            HoraPedido = DateTime.Parse("00:00:00");
            HoraEnvio = DateTime.Parse("00:00:00");
            HoraEntrega = DateTime.Parse("00:00:00");
        }
        public PedidoDomicilioVO(DataRow dr)
        {
            ID_PedidoDomicilio = int.Parse(dr["ID_PedidoDomicilio"].ToString());
            Fecha = DateTime.Parse(dr["Fecha"].ToString());
            HoraPedido = DateTime.Parse(dr["HoraPedido"].ToString());
            HoraEnvio = DateTime.Parse(dr["HoraEnvio"].ToString());
            HoraEntrega = DateTime.Parse(dr["HoraEntrega"].ToString());
        }
    }
}
