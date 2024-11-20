using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class PlatilloComandaVO
    {
        private int _Platillo_ID;
        private int _Comanda_ID;
        private int _Cantidad;
        private string _Extras;

        public int Platillo_ID { get => _Platillo_ID; set => _Platillo_ID = value; }
        public int Comanda_ID { get => _Comanda_ID; set => _Comanda_ID = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Extras { get => _Extras; set => _Extras = value; }

        public PlatilloComandaVO()
        {
            Platillo_ID = 0;
            Comanda_ID = 0;
            Cantidad = 0;
            Extras = string.Empty;
        }
        public PlatilloComandaVO(DataRow dr)
        {
            Platillo_ID = int.Parse(dr["Platillo_ID"].ToString());
            Comanda_ID = int.Parse(dr["Comanda_ID"].ToString());
            Cantidad = int.Parse(dr["Cantidad"].ToString());
            Extras = dr["Extras"].ToString();
        }
    }
}
