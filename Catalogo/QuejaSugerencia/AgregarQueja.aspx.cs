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
    public partial class AgregarQueja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Titulo.Text = "Agregar una queja o sugerencia";
                Subtitulo.Text = "Usted puede agregar su queja o sugerencia respecto a la comida y servicio";
                lblCalificacionServicio.Text = "Calificación de Servicio";
                lblCalificacionComida.Text = "Calificación de Comida";
                lblDescripcion.Text = "Comentario";
                lblComanda_ID.Text = "ID Comanda";
            }
        }

        protected void btnGuardarClick(object sender, EventArgs e)
        {
            QuejaSugerenciaVO qs = new QuejaSugerenciaVO();

            try
            {
                qs.CalificacionServicio = double.Parse(txtCalificacionServicio.Text);
                qs.CalificacionComida = double.Parse(txtCalificacionComida.Text);
                qs.Descripcion = txtDescripcion.Text;
                qs.Comanda_ID = int.Parse(txtComanda_ID.Text);

                InsertarQuejaSugerencia(qs);

                Util.SweetBox("Queja y/o Sugerencia Agregada", "Se ha agregado exitosamente", "success", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                Util.SweetBox("Error", ex.Message, "error", this.Page, this.GetType());
            }
        }

        protected void InsertarQuejaSugerencia(QuejaSugerenciaVO qs)
        {
            BLLQuejaSugerencia.InsertarQuejaSugerencia(qs.CalificacionServicio, qs.CalificacionComida, qs.Descripcion, qs.Comanda_ID);
        }
    }
}