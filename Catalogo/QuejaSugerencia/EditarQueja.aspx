<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarQueja.aspx.cs" Inherits="TaqueriaWEB.Catalogo.QuejaSugerencia.EditarQueja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:Label ID="Titulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        <asp:Label ID="Subtitulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label ID="lblCalificacionServicio" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txtCalificacionServicio" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblCalificacionComida" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txtCalificacionComida" runat="server" CssClass="form-control"></asp:TextBox>
                    
                    <asp:Label ID="lblDescripcion" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                    
                    <asp:Label ID="lblComanda_ID" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txtComanda_ID" runat="server" CssClass="form-control"></asp:TextBox>
                    
                    <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardarClick" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
