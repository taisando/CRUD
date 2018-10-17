<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index2.aspx.cs" Inherits="WebApplicationFundamentoEngenharia.Paginas.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>CRUD</title>
</head>
<!--StyleSheets-->
<link href="../Scripts/font-awesome-4.6.3/css/font-awesome.min.css" rel="stylesheet" />
<link href="../Scripts/css/bootstrap.min.css" rel="stylesheet" />
<link href="../Scripts/css/magnific-popup.css" rel="stylesheet" />
<link href="../Scripts/css/templatemo-style.css" rel="stylesheet" />

<body>
    <div class="container-fluid">

        <section id="welcome" class="tm-content-box tm-banner margin-b-10">
            <div class="tm-banner-inner">
                <h1 class="tm-banner-title">CRUD
                </h1>
            </div>
        </section>

        <div class="tm-body">
            <div class="tm-sidebar">
                <nav class="tm--main-nav">
                    <ul class="tm-main-nav-ul">
                        <li class="tm-nav-item tm-nav-item-link tm-button">
                           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Cadastrar.aspx">
                            <i class="fa fa-tasks tm-nav-fa"></i>Cadastar Cliente</asp:HyperLink>
                        </li>
                        <li class="tm-nav-item tm-nav-item-link tm-button">
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Listar.aspx">
                            <i class="fa fa-book tm-nav-fa"></i>Listar Cliente</asp:HyperLink>
                        </li>
                        <!-- <li class="tm-nav-item tm-nav-item-link tm-button">
                            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Alterar.aspx">
                            <i class="fa fa-calculator tm-nav-fa"></i>Alterar Cliente</asp:HyperLink>
                        </li> -->                       
                    </ul>
                </nav>
            </div>
        </div>

    </div>
</body>

</html>
