using CapaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaBLL
{
    public class BLLDireccion
    {
        //Insertar
        public static void InsertarDireccion(string calle, string numero, string colonia, string municipio, string ciudad, string estado, string cp)
        {
            try
            {
                DALDireccion.InsertarDireccion(calle, numero, colonia, municipio, ciudad, estado, cp);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Listar
        public static List<DireccionVO> GetListDirecciones()
        {
            List<DireccionVO> listResultado = new List<DireccionVO>();
            listResultado = DALDireccion.GetListDirecciones();
            return listResultado;
        }

        //Actualizar
        public static void ActualizarDireccion(int id_direccion, string calle, string numero, string colonia, string municipio, string ciudad, string estado, string cp)
        {
           DALDireccion.ActualizarDireccion(id_direccion, calle, numero, colonia, municipio, ciudad, estado, cp);
        }

        //Eliminar
        public static void EliminarDireccion(int id_direccion)
        {
            try
            {
               DALDireccion.EliminarDireccion(id_direccion);
            }
            catch (Exception)
            {
                throw;
            }


        }

        //Obtener por ID
        public static DireccionVO GetDireccionById(int id_direccion)
        {
            return DALDireccion.GetDireccionById(id_direccion);
        }
    }
}
