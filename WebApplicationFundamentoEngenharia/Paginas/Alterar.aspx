<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="WebApplicationFundamentoEngenharia.Paginas.Alterar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 284px">
            <p>Alterar Funcionário</p><br />
            Nome:
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Salário:<asp:TextBox ID="txtSalario" runat="server"></asp:TextBox>
            <br />
            Crachá:<asp:TextBox ID="txtCracha" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            <br />
            <br />
            <asp:HyperLink ID="linkListar" runat="server" NavigateUrl="Listar.aspx">Listar Funcionários</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
