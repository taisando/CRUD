<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="WebApplicationFundamentoEngenharia.Paginas.Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Lista de Funcionários<br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="fun_nome" HeaderText="Nome" />
                    <asp:BoundField DataField="fun_salario" HeaderText="Salário" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Cadastrar.aspx">Cadastrar Funcionário</asp:HyperLink>
        </div>
    </form>
</body>
</html>
