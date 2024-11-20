using CapaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaBLL
{
    public class BLLIngrediente
    {
        //Insertar
        public static void InsertarIngrediente(string nombre, double cantidad, int platillo_id)
        {
            try
            {
                DALIngrediente.InsertarIngrediente(nombre, cantidad, platillo_id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Listar
        public static List<IngredienteVO> GetListIngredientes()
        {
            List<IngredienteVO> listResultado = new List<IngredienteVO>();
            listResultado = DALIngrediente.GetListIngredientes();
            return listResultado;
        }

        //Actualizar
        public static void ActualizarIngrediente(int id_ingrediente, string nombre, double cantidad, int platillo_id)
        {
            DALIngrediente.ActualizarIngrediente(id_ingrediente, nombre, cantidad, platillo_id);
        }

        //Eliminar
        public static void EliminarIngrediente(int id_ingrediente)
        {
            try
            {
                DALIngrediente.EliminarIngrediente(id_ingrediente);
            }
            catch (Exception)
            {
                throw;
            }


        }

        //Obtener por ID
        public static IngredienteVO GetIngredienteById(int id_ingrediente)
        {
            return DALIngrediente.GetIngredienteById(id_ingrediente);
        }
    }
}
