using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALPlatillo
    {
        //Insertar Platillo
        public static void InsertarPlatillo(string nombre, double precio)
        {
            try
            {
              MetodoDatos.ExecuteNonQuery("sp_InsertarPlatillo", "@Nombre", nombre, "@Precio", precio);

            }
            catch (Exception )
            {
                throw;
            }
        }

        //Listar Platillo
        public static List<PlatilloVO> GetListPlatillo()
        {
            List<PlatilloVO> list = new List<PlatilloVO>();
            try
            {
                DataSet dsplatillo = MetodoDatos.ExecuteDataSet("sp_ListarPlatillos");

                foreach (DataRow dr in dsplatillo.Tables[0].Rows)
                {
                    list.Add(new PlatilloVO(dr));
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Actualizar Platillo
        public static void ActualizarPlatillo(int id_platillo, string nombre, double precio)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_ActualizarPlatillo", "@ID_Platillo", id_platillo, "@Nombre", nombre, "@Precio", precio);
            }
            catch (Exception )
            {
                throw;
            }
        }

        //Eliminar Platillo
        public static void EliminarPlatillo(int id_platillo)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_EliminaPlatillo", "@ID_Platillo", id_platillo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Obtener Platillo por ID
        public static PlatilloVO GetPlatilloById(int id_platillo)
        {
            try
            {
                DataSet dsPlatillo = MetodoDatos.ExecuteDataSet("sp_ObtenerPlatilloPorID", "@ID_Platillo", id_platillo);
                if (dsPlatillo.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsPlatillo.Tables[0].Rows[0];
                    return new PlatilloVO(dr);
                }
                else
                {
                    return new PlatilloVO();
                }


            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
