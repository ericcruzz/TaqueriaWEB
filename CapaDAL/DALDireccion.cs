using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALDireccion
    {
        //Insertar Direccion
        public static void InsertarDireccion(string calle, string numero, string colonia, string municipio, string ciudad, string estado, string cp)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_InsertarDireccion", "@Calle", calle, "@Numero", numero, "@Colonia", colonia, "@Municipio", municipio, "@Ciudad", ciudad, "@Estado", estado, "@CP", cp);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Listar Direcciones
        public static List<DireccionVO> GetListDirecciones()
        {
            List<DireccionVO> list = new List<DireccionVO>();
            try
            {
                DataSet dsdirecciones = MetodoDatos.ExecuteDataSet("sp_ListarDirecciones");

                foreach (DataRow dr in dsdirecciones.Tables[0].Rows)
                {
                    list.Add(new DireccionVO(dr));
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Actualizar Direccion
        public static void ActualizarDireccion(int id_direccion, string calle, string numero, string colonia, string municipio, string ciudad, string estado, string cp)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_ActualizarDireccion", "@ID_Direccion", id_direccion, "@Calle", calle, "@Numero", numero, "@Colonia", colonia, "@Municipio", municipio, "@Ciudad", ciudad, "@Estado", estado, "@CP", cp);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Eliminar Direccion
        public static void EliminarDireccion(int id_direccion)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_EliminaDireccion", "@ID_Direccion", id_direccion);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Obtener Direccion por ID
        public static DireccionVO GetDireccionById(int id_direccion)
        {
            try
            {
                DataSet dsDireccion = MetodoDatos.ExecuteDataSet("sp_ObtenerDireccionPorID", "@ID_Direccion", id_direccion);
                if (dsDireccion.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsDireccion.Tables[0].Rows[0];
                    return new DireccionVO(dr);
                }
                else
                {
                    return new DireccionVO();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
