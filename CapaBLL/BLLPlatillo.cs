using CapaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaBLL
{
    public class BLLPlatillo
    {
        //Insertar
        public static void InsertarPlatillo(string nombre, double precio)
        {
            try
            {
                DALPlatillo.InsertarPlatillo(nombre, precio);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Listar
        public static List<PlatilloVO> GetListPlatillo()
        {
            List<PlatilloVO> listResultado = new List<PlatilloVO>();
            listResultado = DALPlatillo.GetListPlatillo();
            return listResultado;
        }

        //Actualizar
        public static void ActualizarPlatillo(int id_platillo, string nombre, double precio)
        {
            DALPlatillo.ActualizarPlatillo(id_platillo, nombre, precio);
        }

        //Eliminar
        public static void EliminarPlatillo(int id_platillo)
        {
            try
            {
                DALPlatillo.EliminarPlatillo(id_platillo);
            }
            catch (Exception )
            {
                throw;
            }


        }

        //Obtener por ID
        public static PlatilloVO GetPlatilloById(int id_platillo)
        {
            return DALPlatillo.GetPlatilloById(id_platillo);
        }
    }
}
