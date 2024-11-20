<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarClientes.aspx.cs" Inherits="TaqueriaWEB.Catalogo.Clientes.ListarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <div class="row">
            <h3>Lista de Clientes</h3>
            <asp:Button ID="Insert" runat="server" Text ="Insertar Cliente" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="20px" OnClick="Inser_Click" Height="50px" Width="150px" />
            <asp:GridView ID="GVClientes"
                runat="server"
                CssClass="table table-bordered table-striped table-condensed"
                AutoGenerateColumns="false"
                DataKeyNames="ID_Cliente"
                OnRowDeleting="GVClientes_RowDeleting"
                OnRowCommand="GVClientes_RowCommand" 
                >
                <Columns>
                    <asp:BoundField DataField="ID_cliente" HeaderText="Número de Cliente" ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Apellido_Paterno" HeaderText="Apellido Paterno" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Apellido_Materno" HeaderText="Apellido Materno" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" ItemStyle-Width="85px" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" ItemStyle-Width="150px" />

                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="1" ShowHeader="true" Text="Ver informacion"
                        ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="20px" />
                    <asp:CommandField ButtonType="Button" HeaderText="2" ShowDeleteButton="true" ShowHeader="true"
                        ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="20px" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
