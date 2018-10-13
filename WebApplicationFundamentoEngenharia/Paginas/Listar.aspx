<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="WebApplicationFundamentoEngenharia.Paginas.Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        #form1 {
            height: 196px;
            width: 614px;
        }
    </style>
</head>
<body style="height: 248px">
    <form id="form1" runat="server">
        <div>
            Listar Funcionários<br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="fun_nome" HeaderText="Nome" />
                <asp:BoundField DataField="fun_salario" HeaderText="Salário" />
                <asp:BoundField DataField="fun_cracha" HeaderText="Crachá" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
                            CommandArgument='<%# Bind("fun_codigo")%>'>Alterar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"
                            CommandArgument='<%# Bind("fun_codigo")%>'>Excluir</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="cadastrar.aspx">Cadastro de Funcionário</asp:HyperLink>
    </form>
</body>
</html>
