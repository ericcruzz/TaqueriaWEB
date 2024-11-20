using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALQuejaSugerencia
    {
        //Insertar Queja sugerencia
        public static void InsertarQuejaSugerencia(double calificacionServicio, double calificacionComida, string descripcion, int comanda_id)
        {
            try
            {             
                MetodoDatos.ExecuteNonQuery("sp_InsertarQuejaSugerencia", "@CalificacionServicio", calificacionServicio, "@CalificacionComida", calificacionComida, "@Descripcion", descripcion, "@Comanda_ID", comanda_id);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Listar Queja Sugerencia
        public static List<QuejaSugerenciaVO> GetListQuejaSugerencia()
        {
            List<QuejaSugerenciaVO> list = new List<QuejaSugerenciaVO>();
            try
            {
                DataSet dsqs = MetodoDatos.ExecuteDataSet("sp_ListarQuejaSugerencia");

                foreach (DataRow dr in dsqs.Tables[0].Rows)
                {
                    list.Add(new QuejaSugerenciaVO(dr));
                }

                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Actualizar Queja Sugerencia
        public static void ActualizarQuejaSugerencia(int id_quejaSugerencia, double calificacionServicio, double calificacionComida, string descripcion, int comanda_id)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_ActualizarQuejaSugerencia", "@ID_QuejaSugerencia", id_quejaSugerencia, "@CalificacionServicio", calificacionServicio, "@CalificacionComida", calificacionComida, "@Descripcion", descripcion, "@Comanda_ID", comanda_id);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Eliminar Queja Sugerencia
        public static void EliminarQuejaSugerencia(int id_quejaSugerencia)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_EliminaQuejaSugerencia", "@ID_QuejaSugerencia", id_quejaSugerencia);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Obtener QuejaSugerencia por ID
        public static QuejaSugerenciaVO GetQuejaSugerenciaById(int id_quejaSugerencia)
        {
            try
            {
                DataSet dsqs = MetodoDatos.ExecuteDataSet("sp_ObtenerQuejaSugerenciaPorID", "@ID_QuejaSugerencia", id_quejaSugerencia);
                if (dsqs.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsqs.Tables[0].Rows[0];
                    return new QuejaSugerenciaVO(dr);
                }
                else
                {
                    return new QuejaSugerenciaVO();
                }


            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
