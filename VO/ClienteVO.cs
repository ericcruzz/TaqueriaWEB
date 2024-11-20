using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class ClienteVO
    {
        private int _ID_Cliente;
        private string _Nombre;
        private string _Apellido_Paterno;
        private string _Apellido_Materno;
        private string _Telefono;
        private int _Direccion_ID;

        public int ID_Cliente { get => _ID_Cliente; set => _ID_Cliente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido_Paterno { get => _Apellido_Paterno; set => _Apellido_Paterno = value; }
        public string Apellido_Materno { get => _Apellido_Materno; set => _Apellido_Materno = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public int Direccion_ID { get => _Direccion_ID; set => _Direccion_ID = value; }

        public ClienteVO()
        {
            ID_Cliente = 0;
            Nombre = string.Empty;
            Apellido_Paterno = string.Empty;
            Apellido_Materno = string.Empty;
            Telefono = string.Empty;
            Direccion_ID = 0;
        }

        public ClienteVO(DataRow dr)
        {
            ID_Cliente = int.Parse(dr["ID_Cliente"].ToString());
            Nombre = dr["Nombre"].ToString();
            Apellido_Paterno = dr["Apellido_Paterno"].ToString();
            Apellido_Materno = dr["Apellido_Materno"].ToString();
            Telefono = dr["Telefono"].ToString();
            Direccion_ID = int.Parse(dr["Direccion_ID"].ToString());
        }
    }
}
