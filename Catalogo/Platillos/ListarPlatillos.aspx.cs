using CapaBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaqueriaWEB.Utilidades;
using VO;

namespace TaqueriaWEB.Catalogo.Platillos
{
    public partial class ListarPlatillos : System.Web.UI.Page
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
            GVPlatillos.DataSource = ListPlatillos();

            GVPlatillos.DataBind();
        }

        public List<DatosPlatilloVO> ListPlatillos()
        {
            List<PlatilloVO> listpl = BLLPlatillo.GetListPlatillo();

            List<DatosPlatilloVO> listdp = new List<DatosPlatilloVO>();
            List<IngredienteVO> listin = BLLIngrediente.GetListIngredientes();
            foreach (PlatilloVO platillo in listpl)
            {
                List<IngredienteVO> auxi = new List<IngredienteVO>();
                foreach (IngredienteVO ingred in listin)
                {
                    if (ingred.Platillo_ID == platillo.ID_Platillo)
                    {
                        auxi.Add(ingred);
                    }
                }

                DatosPlatilloVO aux = new DatosPlatilloVO(platillo, auxi);
                listdp.Add(aux);
            }

            return listdp;
        }

        protected void GVPlatillos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string IdPlatillo = GVPlatillos.DataKeys[e.RowIndex].Values["ID_Platillo"].ToString();
            if (IdPlatillo != null && IdPlatillo.Length > 0)
            {
                BLLPlatillo.EliminarPlatillo(int.Parse(IdPlatillo));
                
                Util.SweetBox("Platillo eliminado", "El platillo ha sido eliminado exitosamente", "success", this.Page, this.GetType());
            }
            else
            {
                Util.SweetBox("Platillo no eliminado", "No puede eliminar este platillo", "warning", this.Page, this.GetType());
            }
            CargarGrid();
        }

        protected void GVPlatillos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int varIndex = int.Parse(e.CommandArgument.ToString());
                string varPlatilloIDparaenviar = GVPlatillos.DataKeys[varIndex].Values["ID_Platillo"].ToString();
                Response.Redirect("EditarPlatillo.aspx?Id=" + varPlatilloIDparaenviar);
            }
        }

        protected void Inser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarPlatillo.aspx");
        }
    }
}