using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFundamentoEngenharia.App_Code.Persistencia;

namespace WebApplicationFundamentoEngenharia.Paginas
{
    public partial class Listar : System.Web.UI.Page
    {
        private void Carrega()
        {
            FuncionarioBD bd = new FuncionarioBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Carrega();
        }
    }
}