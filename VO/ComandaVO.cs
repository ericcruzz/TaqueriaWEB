using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class ComandaVO
    {
        private int _ID_Comanda;
        private int _Cliente_ID;
        private int _PedidoDomicilio_ID;

        public int ID_Comanda { get => _ID_Comanda; set => _ID_Comanda = value; }
        public int Cliente_ID { get => _Cliente_ID; set => _Cliente_ID = value; }
        public int PedidoDomicilio_ID { get => _PedidoDomicilio_ID; set => _PedidoDomicilio_ID = value; }

        public ComandaVO()
        {
            ID_Comanda = 0;
            Cliente_ID = 0;
            PedidoDomicilio_ID = 0;
        }

        public ComandaVO(DataRow dr)
        {
            ID_Comanda = int.Parse(dr["ID_Comanda"].ToString());
            Cliente_ID = int.Parse(dr["Cliente_ID"].ToString());
            if(dr["PedidoDomicilio_ID"].ToString() != "")
            {
                PedidoDomicilio_ID = int.Parse(dr["PedidoDomicilio_ID"].ToString());
            }
            else
            {
                PedidoDomicilio_ID = 0;
            }
            
        }
    }
}
