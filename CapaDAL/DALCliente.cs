using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALCliente
    {
        //Insertar Cliente
        public static void InsertarCliente(string nombre, string apellido_paterno, string apellido_materno, string telefono, int direccion_id)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_InsertarCliente", "@Nombre", nombre, "@Apellido_Paterno", apellido_paterno, "@Apellido_Materno", apellido_materno, "@Telefono", telefono, "@Direccion_ID", direccion_id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Listar Cliente
        public static List<ClienteVO> GetListClientes()
        {
            List<ClienteVO> list = new List<ClienteVO>();
            try
            {
                DataSet dsclientes = MetodoDatos.ExecuteDataSet("sp_ListarCliente");

                foreach (DataRow dr in dsclientes.Tables[0].Rows)
                {
                    list.Add(new ClienteVO(dr));
                }

                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Actualizar Cliente
        public static void ActualizarCliente(int id_cliente, string nombre, string apellido_paterno, string apellido_materno, string telefono, int direccion_id)
        {
            try
            {
                MetodoDatos.ExecuteNonQuery("sp_ActualizarCliente", "@ID_Cliente", id_cliente, "@Nombre", nombre, "@Apellido_Paterno", apellido_paterno, "@Apellido_Materno", apellido_materno, "@Telefono", telefono, "@Direccion_ID", direccion_id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Eliminar Cliente
        public static void EliminarCliente(int id_cliente)
        {
            try
            {
                 MetodoDatos.ExecuteNonQuery("sp_EliminaCliente", "@ID_Cliente", id_cliente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Obtener Cliente por ID
        public static ClienteVO GetClienteById(int id_cliente)
        {
            try
            {
                DataSet dsCliente = MetodoDatos.ExecuteDataSet("sp_ObtenerClientePorID", "@ID_Cliente", id_cliente);
                if (dsCliente.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsCliente.Tables[0].Rows[0];
                    return new ClienteVO(dr);
                }
                else
                {
                    return new ClienteVO();
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
