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
    public partial class AgregarPlatillo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Titulo.Text = "Agregar un nuevo Platillo";
                Subtitulo.Text = "Usted puede ingresar un nuevo platillo";
                lblNombreP.Text = "Nombre del Platillo";
                lblPrecio.Text = "Precio";
                
            }
        }
        protected void btnGuardarClick(object sender, EventArgs e)
        {
            PlatilloVO platillo = new PlatilloVO();

            try
            {
                platillo.Nombre = txtNombreP.Text;
                platillo.Precio = double.Parse(txtPrecio.Text);

                InsertarPlatillo(platillo);

                Util.SweetBox("Platillo Registrado", "El platillo ha sido agregado exitosamente", "success", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                Util.SweetBox("Error", ex.Message, "error", this.Page, this.GetType());
            }
        }

        protected void InsertarPlatillo(PlatilloVO platillo)
        {
            BLLPlatillo.InsertarPlatillo(platillo.Nombre, platillo.Precio);
        }

    }
}