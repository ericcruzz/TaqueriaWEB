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
    public partial class ListarClientes : System.Web.UI.Page
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
            GVClientes.DataSource = ListClientes();

            GVClientes.DataBind();
        }

        public List<DatosClienteVO> ListClientes()
        {
            List<ClienteVO> listcl = BLLCliente.GetListClientes();

            List<DatosClienteVO> listdc = new List<DatosClienteVO>();

            foreach (ClienteVO cliente in listcl)
            {
                DireccionVO auxd = BLLDireccion.GetDireccionById(cliente.Direccion_ID);
                DatosClienteVO auxc = new DatosClienteVO(cliente, auxd);
                listdc.Add(auxc);
            }

            return listdc;
        }

        protected void GVClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            string IdCliente = GVClientes.DataKeys[e.RowIndex].Values["ID_Cliente"].ToString();
            if (IdCliente != null && IdCliente.Length > 0)
            {
                ClienteVO cl = BLLCliente.GetClienteById(int.Parse(IdCliente));
                BLLCliente.EliminarCliente(int.Parse(IdCliente));
                BLLDireccion.EliminarDireccion(cl.Direccion_ID);
                Util.SweetBox("Cliente eliminado", "El cliente ha sido eliminado exitosamente", "success", this.Page, this.GetType());
            }
            else
            {
                Util.SweetBox("Cliente no eliminado", "No puede eliminar este cliente", "warning", this.Page, this.GetType());
            }            
            CargarGrid();
        }

        protected void GVClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int varIndex = int.Parse(e.CommandArgument.ToString());
                string varClienteIDparaenviar = GVClientes.DataKeys[varIndex].Values["ID_Cliente"].ToString();
                Response.Redirect("EditarCliente.aspx?Id=" + varClienteIDparaenviar);
            }
        }

        protected void Inser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarPlatillo.aspx");
        }
    }
}