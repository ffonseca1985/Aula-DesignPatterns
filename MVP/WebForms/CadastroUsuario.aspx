<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="WebForms.CadastroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Nome"></asp:Label>
            <asp:TextBox runat="server" ID="txtNome"></asp:TextBox>
        </div>

        <div>
            <asp:Label runat="server" Text="Email"></asp:Label>
            <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
        </div>

        <div>
            <asp:Button runat="server" ID ="btnUsuario" Text="Salvar" OnClick="btnUsuario_Click"/>
        </div>

    </form>

    <div>
        <asp:Repeater runat="server" ID="rptUsuarios">
            <HeaderTemplate>
                <table>
                    <tr>
                        <td>Id</td>
                        <td>Nome</td>
                        <td>Email</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tbody>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("Nome") %></td>
                        <td><%# Eval("Email") %></td>
                    </tr>
                </tbody>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>


</body>
</html>
