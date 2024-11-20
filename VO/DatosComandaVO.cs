using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class DatosComandaVO
    {
        private int _ID_Comanda;
        private string _Nombre;
        private string _Platillo;
        private int _Cantidad;

        public int ID_Comanda { get => _ID_Comanda; set => _ID_Comanda = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Platillo { get => _Nombre; set => _Nombre = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }

        public DatosComandaVO()
        {
            ID_Comanda = 0;
            Nombre = string.Empty;
            Platillo = string.Empty;
            Cantidad = 0;
        }

        public DatosComandaVO(DataRow dr)
        {
            ID_Comanda = int.Parse(dr["ID_Comanda"].ToString());
            Nombre = dr["Nombre"].ToString();
            Platillo = dr["Platillo"].ToString();
            Cantidad = int.Parse(dr["Cantidad"].ToString());
        }
    }
}
