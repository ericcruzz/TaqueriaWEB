using CapaBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaqueriaWEB.Utilidades;
using VO;

namespace TaqueriaWEB.Catalogo.Clientes
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

                lblNombre.Text = "Nombre";
                lblApellidoPaterno.Text = "Apellido Paterno";
                lblApellidoMaterno.Text = "Apellido Materno";
                lblTelefono.Text = "Telefono";
                lblCalle.Text = "Calle";
                lblNumero.Text = "Numero";
                lblColonia.Text = "Colonia";
                lblMunicipio.Text = "Municipio";
                lblCiudad.Text = "Ciudad";
                lblEstado.Text = "Estado";
                lblCP.Text = "CP";
            }
        }

        protected void btnGuardarClick(object sender, EventArgs e)
        {
            ClienteVO cliente = new ClienteVO();
            DireccionVO dir = new DireccionVO();

            try
            {
                dir.Calle = txtCalle.Text;
                dir.Numero = txtNumero.Text;
                dir.Colonia = txtColonia.Text;
                dir.Municipio = txtMunicipio.Text;
                dir.Ciudad = txtCiudad.Text;
                dir.Estado = txtEstado.Text;
                dir.CP = txtCP.Text;

                cliente.Direccion_ID = InsertarDireccion(dir);
                if (cliente.Direccion_ID > 0)
                {
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido_Paterno = txtApellidoPaterno.Text;
                    cliente.Apellido_Materno = txtApellidoMaterno.Text;
                    cliente.Telefono = txtTelefono.Text;
                    InsertarCliente(cliente);
                }
                Util.SweetBox("Cliente Registrado", "El cliente ha sido agregado exitosamente", "success", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                Util.SweetBox("Error", ex.Message, "error", this.Page, this.GetType());
            }
        }

        protected int InsertarDireccion(DireccionVO dir)
        {
            BLLDireccion.InsertarDireccion(dir.Calle, dir.Numero, dir.Colonia, dir.Municipio, dir.Ciudad, dir.Estado, dir.CP);

            List<DireccionVO> list = BLLDireccion.GetListDirecciones();

            return list.Last().ID_Direccion;
        }
        protected void InsertarCliente(ClienteVO cl)
        {
            BLLCliente.InsertarCliente(cl.Nombre, cl.Apellido_Paterno, cl.Apellido_Materno, cl.Telefono, cl.Direccion_ID);

        }
    }
}