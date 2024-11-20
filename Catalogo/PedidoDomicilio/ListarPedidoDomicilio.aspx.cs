using CapaBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace TaqueriaWEB.Catalogo.PedidoDomicilio
{
    public partial class ListarPedidoDomicilio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    CargarGrid();
                }
                catch (Exception)
                {

                }
            }
        }

        public void CargarGrid()
        {
            GVPedidos.DataSource = ListPedidos();

            GVPedidos.DataBind();
        }

        public List<DatosPedidoVO> ListPedidos()
        {
            List<PedidoDomicilioVO> listpd = BLLPedidoDomicilio.GetListPedidoDomicilio();
            List<ComandaVO> listcm = BLLComanda.GetListComandas();
            List<PlatilloComandaVO> listpc = BLLPlatilloComanda.GetListPlatilloComanda();
            List<PlatilloVO> listp = BLLPlatillo.GetListPlatillo();
            
            List<DatosPedidoVO> listdp = new List<DatosPedidoVO>();

            foreach (PedidoDomicilioVO pd in listpd)
            {
                foreach(ComandaVO comanda in listcm)
                {
                    if(comanda.PedidoDomicilio_ID == pd.ID_PedidoDomicilio)
                    {
                        List<PlatilloVO> lp = new List<PlatilloVO>();
                        int[] cant = new int[5];
                        int i = 0;
                        foreach (PlatilloComandaVO pc in listpc)
                        {
                            if (pc.Comanda_ID == comanda.ID_Comanda)
                            {
                                lp.Add(BLLPlatillo.GetPlatilloById(pc.Platillo_ID));
                                cant[i] = pc.Cantidad;
                                i++;
                            }
                            
                        }
                        DatosPedidoVO auxc = new DatosPedidoVO(pd, lp, cant);
                        listdp.Add(auxc);
                    }
                } 
            }

            return listdp;
        }


    }
}