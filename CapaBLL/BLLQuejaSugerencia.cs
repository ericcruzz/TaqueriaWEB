using CapaDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaBLL
{
    public class BLLQuejaSugerencia
    {
        //Insertar Queja sugerencia
        public static void InsertarQuejaSugerencia(double calificacionServicio, double calificacionComida, string descripcion, int comanda_id)
        {
            try
            {
                DALQuejaSugerencia.InsertarQuejaSugerencia(calificacionServicio, calificacionComida, descripcion, comanda_id);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Listar Queja Sugerencia
        public static List<QuejaSugerenciaVO> GetListQuejaSugerencia()
        {
            return DALQuejaSugerencia.GetListQuejaSugerencia();
           
        }

        //Actualizar Queja Sugerencia
        public static void ActualizarQuejaSugerencia(int id_quejaSugerencia, double calificacionServicio, double calificacionComida, string descripcion, int comanda_id)
        {
            try
            {
                DALQuejaSugerencia.ActualizarQuejaSugerencia(id_quejaSugerencia, calificacionServicio, calificacionComida, descripcion, comanda_id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Eliminar Queja Sugerencia
        public static void EliminarQuejaSugerencia(int id_quejaSugerencia)
        {
            try
            {
                DALQuejaSugerencia.EliminarQuejaSugerencia(id_quejaSugerencia);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Obtener QuejaSugerencia por ID
        public static QuejaSugerenciaVO GetQuejaSugerenciaById(int id_quejaSugerencia)
        {
            return DALQuejaSugerencia.GetQuejaSugerenciaById(id_quejaSugerencia);
        }
    }
}
