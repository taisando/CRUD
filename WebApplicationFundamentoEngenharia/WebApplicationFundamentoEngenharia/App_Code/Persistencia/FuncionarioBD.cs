using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFundamentoEngenharia.App_Code.Classes;
using System.Data; //para uso de DataSet

namespace WebApplicationFundamentoEngenharia.App_Code.Persistencia
{
    public class FuncionarioBD
    {

        //métodos
        //insert
        public bool Insert(Funcionario funcionario) //assinatura do metodo
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_funcionario(fun_nome, fun_salario, fun_cracha) VALUES (?nome, ?salario, ?cracha)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?salario", funcionario.Salario));
            objCommand.Parameters.Add(Mapped.Parameter("?cracha", funcionario.Cracha));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
            //construtor
        }
        public FuncionarioBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionario", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }


    }
}