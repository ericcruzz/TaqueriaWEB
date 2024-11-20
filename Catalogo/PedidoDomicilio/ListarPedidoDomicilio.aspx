<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarPedidoDomicilio.aspx.cs" Inherits="TaqueriaWEB.Catalogo.PedidoDomicilio.ListarPedidoDomicilio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3>Lista de Pedidos a Domicilio</h3>
            <%--<asp:Button ID="Insert" runat="server" Text ="Insertar Pedido a Domicilio" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="20px" OnClick="Inser_Click" Height="50px" Width="150px" />--%>
            <asp:GridView ID="GVPedidos"
                runat="server"
                CssClass="table table-bordered table-striped table-condensed"
                AutoGenerateColumns="false"
                DataKeyNames="ID_PedidoDomicilio"
                
                >
                <Columns>
                    <asp:BoundField DataField="ID_pedidodomicilio" HeaderText="Número de Pedido" ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Pedido" HeaderText="Pedido" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="HoraPedido" HeaderText="Hora de Pedido" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="HoraEnvio" HeaderText="Hora de Envio" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="HoraEntrega" HeaderText="Hora de Entrega" ItemStyle-Width="150px" />

                    <%--<asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="1" ShowHeader="true" Text="Ver informacion"
                        ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="20px" />
                    <asp:CommandField ButtonType="Button" HeaderText="2" ShowDeleteButton="true" ShowHeader="true"
                        ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="20px" />--%>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
