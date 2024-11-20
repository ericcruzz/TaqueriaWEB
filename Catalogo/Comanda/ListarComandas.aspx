<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarComandas.aspx.cs" Inherits="TaqueriaWEB.Catalogo.Comanda.ListarComandas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3>Lista de Comandas</h3>
            <%--<asp:Button ID="Insert" runat="server" Text ="Insertar Pedido a Domicilio" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="20px" OnClick="Inser_Click" Height="50px" Width="150px" />--%>
            <asp:GridView ID="GVComandas"
                runat="server"
                CssClass="table table-bordered table-striped table-condensed"
                AutoGenerateColumns="false"
                DataKeyNames="ID_Comanda"
                
                >
                <Columns>
                    <asp:BoundField DataField="Id_comanda" HeaderText="Número de Comanda" ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre del Cliente" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Platillo" HeaderText="Platillo" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" ItemStyle-Width="85px" />

                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="1" ShowHeader="true" Text="Ver informacion"
                        ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="20px" />
                    <asp:CommandField ButtonType="Button" HeaderText="2" ShowDeleteButton="true" ShowHeader="true"
                        ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="20px" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
