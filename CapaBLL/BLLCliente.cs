using CapaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaBLL
{
    public class BLLCliente
    {
        //Insertar
        public static void InsertarCliente(string nombre, string apellido_paterno, string apellido_materno, string telefono, int direccion_id)
        {
            try
            {
                DALCliente.InsertarCliente(nombre, apellido_paterno, apellido_materno, telefono, direccion_id);
            }
            catch (Exception)
            {
               throw;
            }
        }

        //Listar
        public static List<ClienteVO> GetListClientes()
        {
            List<ClienteVO> listResultado = DALCliente.GetListClientes();
            return listResultado;
        }

        //Actualizar
        public static void ActualizarCliente(int id_cliente, string nombre, string apellido_paterno, string apellido_materno, string telefono, int direccion_id)
        {
           DALCliente.ActualizarCliente(id_cliente, nombre, apellido_paterno, apellido_materno, telefono, direccion_id);
        }

        //Eliminar
        public static void EliminarCliente(int id_cliente)
        {
            try
            {
                DALCliente.EliminarCliente(id_cliente);
            }
            catch (Exception)
            {
                throw;
            }


        }

        //Obtener por ID
        public static ClienteVO GetClienteById(int id_cliente)
        {
            return DALCliente.GetClienteById(id_cliente);
        }
    }
}
