<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarQueja.aspx.cs" Inherits="TaqueriaWEB.Catalogo.QuejaSugerencia.ListarQueja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3>Lista de Quejas y Sugerencias</h3>
            <asp:Button ID="Insert" runat="server" Text ="Insertar Queja y/o Sugerencia" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="20px" OnClick="Inser_Click" Height="50px" Width="289px" />
            <asp:GridView ID="GVQuejas"
                runat="server"
                CssClass="table table-bordered table-striped table-condensed"
                AutoGenerateColumns="false"
                DataKeyNames="ID_QuejaSugerencia"
                OnRowDeleting="GVQuejas_RowDeleting"
                OnRowCommand="GVQuejas_RowCommand" 
                >
                <Columns>
                    <asp:BoundField DataField="ID_quejasugerencia" HeaderText="Número de la Queja Sugerencia" ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="CalificacionServicio" HeaderText="Calificacion Servicio" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="CalificacionComida" HeaderText="Calificacion Comida" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Comentario" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Comanda_ID" HeaderText="ID Comanda" ItemStyle-Width="85px" />

                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="1" ShowHeader="true" Text="Ver informacion"
                        ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="20px" />
                    <asp:CommandField ButtonType="Button" HeaderText="2" ShowDeleteButton="true" ShowHeader="true"
                        ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="20px" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
