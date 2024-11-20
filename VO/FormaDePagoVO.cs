using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class FormaDePagoVO
    {
        private int _ID_FormaDePago;
        private string _Nombre;
        private string _Tipo;
        private string _Descripcion;

        public int ID_FormaDePago { get => _ID_FormaDePago; set => _ID_FormaDePago = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        public FormaDePagoVO()
        {
            ID_FormaDePago = 0;
            Nombre = string.Empty;
            Tipo = string.Empty;
            Descripcion = string.Empty;
        }
        public FormaDePagoVO(DataRow dr)
        {
            ID_FormaDePago = int.Parse(dr["ID_FormaDePago"].ToString());
            Nombre = dr["Nombre"].ToString();
            Tipo = dr["Tipo"].ToString();
            Descripcion = dr["Descripcion"].ToString();
        }
    }
}
