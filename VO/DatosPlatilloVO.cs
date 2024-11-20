using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class DatosPlatilloVO
    {
        private int _ID_Platillo;
        private string _Nombre;
        private double _Precio;
        private string _Ingredientes;

        public int ID_Platillo { get => _ID_Platillo; set => _ID_Platillo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public string Ingredientes { get => _Ingredientes; set => _Ingredientes = value; }

        public DatosPlatilloVO()
        {
            ID_Platillo = 0;
            Nombre = string.Empty;
            Precio = 0;
        }

        public DatosPlatilloVO(PlatilloVO pl, List<IngredienteVO> ing)
        {
            ID_Platillo = pl.ID_Platillo;
            Nombre = pl.Nombre;
            Precio = pl.Precio;
            Ingredientes = "";
            foreach(IngredienteVO ling in ing) 
            {
                Ingredientes = Ingredientes + ling.Cantidad + " " + ling.Nombre + ". \n";
            }
            
        }
    }
}
