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
    public partial class EditarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Titulo.Text = "Editar Cliente";
                Subtitulo.Text = "Usted puede editar un cliente";
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

                if (Request.QueryString["Id"] != null)
                {
                    int varIdcliente = int.Parse(Request.QueryString["Id"]);
                    ClienteVO cliente = BLLCliente.GetClienteById(varIdcliente);
                    DireccionVO dir = BLLDireccion.GetDireccionById(cliente.Direccion_ID);
                    if (cliente.ID_Cliente != 0 && dir.ID_Direccion != 0)
                    {
                        txtNombre.Text = cliente.Nombre;
                        txtApellidoPaterno.Text = cliente.Apellido_Paterno;
                        txtApellidoMaterno.Text = cliente.Apellido_Materno;
                        txtTelefono.Text = cliente.Telefono;
                        txtCalle.Text = dir.Calle;
                        txtNumero.Text = dir.Numero;
                        txtColonia.Text = dir.Colonia;
                        txtMunicipio.Text = dir.Municipio;
                        txtCiudad.Text = dir.Ciudad;
                        txtEstado.Text = dir.Estado;
                        txtCP.Text = dir.CP;
                    }
                }
            }
        }

        protected void btnGuardarClick(object sender, EventArgs e)
        {
            ClienteVO cliente = new ClienteVO();

            DireccionVO dir = new DireccionVO();
            try
            {
                ClienteVO aux = BLLCliente.GetClienteById(int.Parse(Request.QueryString["Id"]));

                cliente.ID_Cliente = int.Parse(Request.QueryString["Id"]);
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido_Paterno = txtApellidoPaterno.Text;
                cliente.Apellido_Materno = txtApellidoMaterno.Text;
                cliente.Telefono = txtTelefono.Text;
                dir.ID_Direccion = aux.Direccion_ID;
                dir.Calle = txtCalle.Text;
                dir.Numero = txtNumero.Text;
                dir.Colonia = txtColonia.Text;
                dir.Municipio = txtMunicipio.Text;
                dir.Ciudad = txtCiudad.Text;
                dir.Estado = txtEstado.Text;
                dir.CP = txtCP.Text;

                string respuesta = Actualizar(cliente, dir);
                //Response.Redirect("ListarClientes.aspx");
                Util.SweetBox("Actualizacion Exitosa", respuesta, "success", this.Page, this.GetType());

            }
            catch (Exception ex)
            {
                Util.SweetBox("Error", ex.Message, "error", this.Page, this.GetType());
            }

           
        }

        protected string Actualizar(ClienteVO cl, DireccionVO dir)
        {
            try
            {
                BLLCliente.ActualizarCliente(cl.ID_Cliente, cl.Nombre, cl.Apellido_Paterno, cl.Apellido_Materno, cl.Telefono, dir.ID_Direccion);
                BLLDireccion.ActualizarDireccion(dir.ID_Direccion, dir.Calle, dir.Numero, dir.Colonia, dir.Municipio, dir.Ciudad, dir.Estado, dir.CP);

                return "El cliente se actualizó correctamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

        }
    }
}