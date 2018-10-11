using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFundamentoEngenharia.App_Code.Classes;
using WebApplicationFundamentoEngenharia.App_Code.Persistencia;

namespace WebApplicationFundamentoEngenharia.Paginas
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text.Trim ();
            funcionario.Salario = Convert.ToDouble ( txtSalario.Text);
            funcionario.Cracha = txtCracha.Text;

            FuncionarioBD bd = new FuncionarioBD();
            bd.Insert(funcionario);
                Response.Write ("Funcionário cadastrado com sucesso");
                     
        }
    }
}