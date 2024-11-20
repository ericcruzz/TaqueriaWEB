using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALIngrediente
    {
        //Insertar Ingrediente
        public static void InsertarIngrediente(string nombre, double cantidad, int platillo_id)
        {
            try
            {
               MetodoDatos.ExecuteNonQuery("sp_InsertarIngrediente", "@Nombre", nombre, "@Cantidad", cantidad, "@Platillo_ID", platillo_id);

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Listar Ingredientes
        public static List<IngredienteVO> GetListIngredientes()
        {
            List<IngredienteVO> list = new List<IngredienteVO>();
            try
            {
                DataSet dsingredientes = MetodoDatos.ExecuteDataSet("sp_ListarIngredientes");

                foreach (DataRow dr in dsingredientes.Tables[0].Rows)
                {
                    list.Add(new IngredienteVO(dr));
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Actualizar Ingrediente
        public static void ActualizarIngrediente(int id_ingrediente, string nombre, double cantidad, int platillo_id)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_ActualizarIngrediente", "@ID_Ingrediente", id_ingrediente, "@Nombre", nombre, "@Cantidad", cantidad, "@Platillo_ID", platillo_id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Eliminar Ingrediente
        public static void EliminarIngrediente(int id_ingrediente)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_EliminaIngrediente", "@ID_Ingrediente", id_ingrediente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Obtener Ingrediente por ID
        public static IngredienteVO GetIngredienteById(int id_ingrediente)
        {
            try
            {
                DataSet dsIngrediente = MetodoDatos.ExecuteDataSet("sp_ObtenerIngredientePorID", "@ID_Ingrediente", id_ingrediente);
                if (dsIngrediente.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsIngrediente.Tables[0].Rows[0];
                    return new IngredienteVO(dr);
                }
                else
                {
                    return new IngredienteVO();
                }

            }
            catch (Exception )
            {
                throw;
            }
        }
    }
}
