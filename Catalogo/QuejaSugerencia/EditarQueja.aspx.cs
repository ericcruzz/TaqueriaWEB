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
    public partial class EditarQueja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCalificacionServicio.Text = "Calificacion del Servicio";
                lblCalificacionComida.Text = "Calificacion de la Comida";
                lblDescripcion.Text = "Comentario";
                lblComanda_ID.Text = "ID Comanda";

                if (Request.QueryString["Id"] != null)
                {
                    int varId = int.Parse(Request.QueryString["Id"]);
                    QuejaSugerenciaVO qs = BLLQuejaSugerencia.GetQuejaSugerenciaById(varId);
                    txtCalificacionServicio.Text = qs.CalificacionServicio.ToString();
                    txtCalificacionComida.Text = qs.CalificacionComida.ToString();
                    txtDescripcion.Text = qs.Descripcion.ToString();
                    txtComanda_ID.Text = qs.Comanda_ID.ToString();
                }
            }
        }

        protected void btnGuardarClick(object sender, EventArgs e)
        {
            QuejaSugerenciaVO qs = new QuejaSugerenciaVO();

            try
            {
                qs.ID_QuejaSugerencia = int.Parse(Request.QueryString["Id"]);
                qs.CalificacionServicio = double.Parse(txtCalificacionServicio.Text);
                qs.CalificacionComida = double.Parse(txtCalificacionComida.Text);
                qs.Descripcion = txtDescripcion.Text;
                qs.Comanda_ID = int.Parse(txtComanda_ID.Text);

                Actualizar(qs);

                Util.SweetBox("Queja y/o Sugerencia Actualizado", "Se ha sido actualizado exitosamente", "success", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                Util.SweetBox("Error", ex.Message, "error", this.Page, this.GetType());
            }
        }

        protected void Actualizar(QuejaSugerenciaVO qs)
        {
            BLLQuejaSugerencia.ActualizarQuejaSugerencia(qs.ID_QuejaSugerencia, qs.CalificacionServicio, qs.CalificacionComida,qs.Descripcion,qs.Comanda_ID);
        }
    }
}