using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class DatosClienteVO
    {
        private int _ID_Cliente;
        private string _Nombre;
        private string _Apellido_Paterno;
        private string _Apellido_Materno;
        private string _Telefono;
        private string _Direccion;

        public int ID_Cliente { get => _ID_Cliente; set => _ID_Cliente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido_Paterno { get => _Apellido_Paterno; set => _Apellido_Paterno = value; }
        public string Apellido_Materno { get => _Apellido_Materno; set => _Apellido_Materno = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }

        public DatosClienteVO()
        {
            ID_Cliente = 0;
            Nombre = string.Empty;
            Apellido_Paterno = string.Empty;
            Apellido_Materno = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
        }

        public DatosClienteVO(ClienteVO cl, DireccionVO dir)
        {
            ID_Cliente = cl.ID_Cliente;
            Nombre = cl.Nombre;
            Apellido_Paterno = cl.Apellido_Paterno;
            Apellido_Materno = cl.Apellido_Materno;
            Telefono = cl.Telefono;
            Direccion = "Calle " + dir.Calle + " #" + dir.Numero + " Col." + dir.Colonia + ", " + dir.Municipio + ", " + dir.Estado + ". C.P. " + dir.CP;
        }
    }
}
