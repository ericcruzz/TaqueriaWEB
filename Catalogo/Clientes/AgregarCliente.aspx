<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="TaqueriaWEB.Catalogo.Clientes.AgregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:Label ID="Titulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        <asp:Label ID="Subtitulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblNombre" runat="server" Text="">Nombre</asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblApellidoPaterno" runat="server" Text="">Apellido Paterno</asp:Label>
                    <asp:TextBox ID="txtApellidoPaterno" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblApellidoMaterno" runat="server" Text="">Apellido Materno</asp:Label>
                    <asp:TextBox ID="txtApellidoMaterno" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblTelefono" runat="server" Text="">Telefono</asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>

                    <div class="form-group">
                        <asp:Label ID="lblCalle" runat="server" Text="">Calle</asp:Label>
                        <asp:TextBox ID="txtCalle" runat="server" CssClass="form-control"></asp:TextBox>

                        <asp:Label ID="lblNumero" runat="server" Text="">Telefono</asp:Label>
                        <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control"></asp:TextBox>

                        <asp:Label ID="lblColonia" runat="server" Text="">Colonia</asp:Label>
                        <asp:TextBox ID="txtColonia" runat="server" CssClass="form-control"></asp:TextBox>

                        <asp:Label ID="lblMunicipio" runat="server" Text="">Municipio</asp:Label>
                        <asp:TextBox ID="txtMunicipio" runat="server" CssClass="form-control"></asp:TextBox>

                        <asp:Label ID="lblCiudad" runat="server" Text="">Ciudad</asp:Label>
                        <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control"></asp:TextBox>

                        <asp:Label ID="lblEstado" runat="server" Text="">Estado</asp:Label>
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control"></asp:TextBox>

                        <asp:Label ID="lblCP" runat="server" Text="">CP</asp:Label>
                        <asp:TextBox ID="txtCP" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardarClick" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
