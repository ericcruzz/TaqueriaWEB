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
    public partial class EditarPlatillo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblNombreP.Text = "Nombre del Platillo";
                lblPrecio.Text = "Precio";

                if (Request.QueryString["Id"] != null)
                {
                    int varId = int.Parse(Request.QueryString["Id"]);
                    PlatilloVO platillo = BLLPlatillo.GetPlatilloById(varId);
                    txtNombreP.Text = platillo.Nombre.ToString();
                    txtPrecio.Text = platillo.Precio.ToString();
                }
            }
        }
        protected void btnGuardarClick(object sender, EventArgs e)
        {
            PlatilloVO platillo = new PlatilloVO();

            try
            {
                platillo.ID_Platillo = int.Parse(Request.QueryString["Id"]);
                platillo.Nombre = txtNombreP.Text;
                platillo.Precio = double.Parse(txtPrecio.Text);

                Actualizar(platillo);

                Util.SweetBox("Platillo Actualizado", "El platillo ha sido actualizado exitosamente", "success", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                Util.SweetBox("Error", ex.Message, "error", this.Page, this.GetType());
            }
        }

        protected void Actualizar(PlatilloVO platillo)
        {
            BLLPlatillo.ActualizarPlatillo(platillo.ID_Platillo, platillo.Nombre, platillo.Precio);
        }

    }
}