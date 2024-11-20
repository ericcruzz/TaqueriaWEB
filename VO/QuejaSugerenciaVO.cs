using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class QuejaSugerenciaVO
    {
        private int _ID_QuejaSugerencia;
        private double _CalificacionServicio;
        private double _CalificacionComida;
        private string _Descripcion;
        private int _Comanda_ID;

        public int ID_QuejaSugerencia { get => _ID_QuejaSugerencia; set => _ID_QuejaSugerencia = value; }
        public double CalificacionServicio { get => _CalificacionServicio; set => _CalificacionServicio = value; }
        public double CalificacionComida { get => _CalificacionComida; set => _CalificacionComida = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Comanda_ID { get => _Comanda_ID; set => _Comanda_ID = value; }

        public QuejaSugerenciaVO()
        {
            ID_QuejaSugerencia = 0;
            CalificacionServicio = 0;
            CalificacionComida = 0;
            Descripcion = string.Empty;
            Comanda_ID = 0;
        }

        public QuejaSugerenciaVO(DataRow dr)
        {
            ID_QuejaSugerencia = int.Parse(dr["ID_QuejaSugerencia"].ToString());
            CalificacionServicio = double.Parse(dr["CalificacionServicio"].ToString());
            CalificacionComida = double.Parse(dr["CalificacionComida"].ToString());
            Descripcion = dr["Descripcion"].ToString();
            Comanda_ID = int.Parse(dr["Comanda_ID"].ToString());
        }
    }
}
