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
    public class BLLComandaInfo
    {
        //Listar Informacion de Comandas
        public static List<DatosComandaVO> GetListComandaInfo(int id_cliente, int id_comanda)
        {
           return DALComandaInfo.GetListComandaInfo(id_cliente, id_comanda);            
        }
    }
}
