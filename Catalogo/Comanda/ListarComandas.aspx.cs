using CapaBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace TaqueriaWEB.Catalogo.Comanda
{
    public partial class ListarComandas : System.Web.UI.Page
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
            GVComandas.DataSource = ListComandas();

            GVComandas.DataBind();
        }

        public List<List<DatosComandaVO>> ListComandas()
        {
            List<ClienteVO> listcl = BLLCliente.GetListClientes();
            List<ComandaVO> listco = BLLComanda.GetListComandas();
            List<List<DatosComandaVO>> listl = new List<List<DatosComandaVO>>();

            foreach (ClienteVO cliente in listcl)
            {
                foreach(ComandaVO comanda in listco)
                {
                    if(comanda.Cliente_ID == cliente.ID_Cliente)
                    {
                        List<DatosComandaVO> list = BLLComandaInfo.GetListComandaInfo(cliente.ID_Cliente,comanda.ID_Comanda);
                        listl.Add(list);
                    }
                    
                }
            }
            

            return listl;
        }
    }
}