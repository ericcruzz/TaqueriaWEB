<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarPlatillo.aspx.cs" Inherits="TaqueriaWEB.Catalogo.Platillos.AgregarPlatillo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:Label ID="Titulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        <asp:Label ID="Subtitulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblNombreP" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txtNombreP" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblPrecio" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
                    
                    <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardarClick" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
