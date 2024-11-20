using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDAL
{
    public class DALComandaInfo
    {
        //Listar Informacion de Comandas
        public static List<DatosComandaVO> GetListComandaInfo(int id_cliente, int id_comanda)
        {
            List<DatosComandaVO> list = new List<DatosComandaVO>();
            try
            {
                DataSet ds = MetodoDatos.ExecuteDataSet("sp_ListarComandasInfo", "@ID_Cliente", id_cliente, "@ID_Comanda", id_comanda);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    list.Add(new DatosComandaVO(dr));
                }

                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
