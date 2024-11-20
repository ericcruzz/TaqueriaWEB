using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class DireccionVO
    {
        private int _ID_Direccion;
        private string _Calle;
        private string _Numero;
        private string _Colonia;
        private string _Municipio;
        private string _Ciudad;
        private string _Estado;
        private string _CP;

        public int ID_Direccion { get => _ID_Direccion; set => _ID_Direccion = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string CP { get => _CP; set => _CP = value; }
        public DireccionVO()
        {
            ID_Direccion = 0;
            Calle = string.Empty;
            Numero = string.Empty;
            Colonia = string.Empty;
            Municipio = string.Empty;
            Ciudad = string.Empty;
            Estado = string.Empty;
            CP = string.Empty;
        }
        public DireccionVO(DataRow dr)
        {
            ID_Direccion = int.Parse(dr["ID_Direccion"].ToString());
            Calle = dr["Calle"].ToString();
            Numero = dr["Numero"].ToString();
            Colonia = dr["Colonia"].ToString();
            Municipio = dr["Municipio"].ToString();
            Ciudad = dr["Ciudad"].ToString();
            Estado = dr["Estado"].ToString();
            CP = dr["CP"].ToString();
        }
    }
}
