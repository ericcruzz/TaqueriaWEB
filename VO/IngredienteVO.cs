using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class IngredienteVO
    {
        private int _ID_Ingrediente;
        private string _Nombre;
        private double _Cantidad;
        private int _Platillo_ID;

        public int ID_Ingrediente { get => _ID_Ingrediente; set => _ID_Ingrediente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public double Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public int Platillo_ID { get => _Platillo_ID; set => _Platillo_ID = value; }

        public IngredienteVO()
        {
            ID_Ingrediente = 0;
            Nombre = string.Empty;
            Cantidad = 0;
            Platillo_ID = 0;
        }

        public IngredienteVO(DataRow dr)
        {
            ID_Ingrediente = int.Parse(dr["ID_Ingrediente"].ToString());
            Nombre = dr["Nombre"].ToString();
            Cantidad = double.Parse(dr["Cantidad"].ToString());
            Platillo_ID = int.Parse(dr["Platillo_ID"].ToString());
        }
    }
}
