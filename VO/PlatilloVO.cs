using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class PlatilloVO
    {
        private int _ID_Platillo;
        private string _Nombre;
        private double _Precio;

        public int ID_Platillo { get => _ID_Platillo; set => _ID_Platillo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public double Precio { get => _Precio; set => _Precio = value; }

        public PlatilloVO()
        {
            ID_Platillo = 0;
            Nombre = string.Empty;
            Precio = 0;
        }

        public PlatilloVO(DataRow dr)
        {
            ID_Platillo = int.Parse(dr["ID_Platillo"].ToString());
            Nombre = dr["Nombre"].ToString();
            Precio = double.Parse(dr["Precio"].ToString());
        }
    }
}
