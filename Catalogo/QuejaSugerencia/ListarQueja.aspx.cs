using CapaBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaqueriaWEB.Utilidades;
using VO;

namespace TaqueriaWEB.Catalogo.QuejaSugerencia
{
    public partial class ListarQueja : System.Web.UI.Page
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
            GVQuejas.DataSource = BLLQuejaSugerencia.GetListQuejaSugerencia();

            GVQuejas.DataBind();
        }

        protected void GVQuejas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            string IdQueja = GVQuejas.DataKeys[e.RowIndex].Values["ID_QuejaSugerencia"].ToString();
            if (IdQueja != null && IdQueja.Length > 0)
            {
               
                BLLQuejaSugerencia.EliminarQuejaSugerencia(int.Parse(IdQueja));
               
                Util.SweetBox("Cliente eliminado", "El cliente ha sido eliminado exitosamente", "success", this.Page, this.GetType());
            }
            else
            {
                Util.SweetBox("Cliente no eliminado", "No puede eliminar este cliente", "warning", this.Page, this.GetType());
            }
            CargarGrid();
        }

        protected void GVQuejas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int varIndex = int.Parse(e.CommandArgument.ToString());
                string varQuejaIDparaenviar = GVQuejas.DataKeys[varIndex].Values["ID_QuejaSugerencia"].ToString();
                Response.Redirect("EditarQueja.aspx?Id=" + varQuejaIDparaenviar);
            }
        }

        protected void Inser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarQueja.aspx");
        }
    }
}