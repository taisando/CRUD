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
            string sql = "INSERT INTO tbl_funcionario(fun_codigo, fun_nome, fun_salario, fun_cracha) VALUES (?nome, ?salario, ?cracha)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", funcionario.Codigo));
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
        //select
        public Funcionario Select(int id)
        {
            Funcionario obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionario WHERE fun_nome = ?nome", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Funcionario();
                obj.Codigo = Convert.ToInt32(objDataReader["fun_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["fun_nome"]);
                obj.Salario = Convert.ToDouble(objDataReader["fun_salario"]);
                obj.Cracha = Convert.ToString(objDataReader["fun_cracha"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        //update
        public bool Update(Funcionario funcionario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_funcionario SET fun_nome=?nome, fun_salario=?salario, fun_cracha=?cracha WHERE fun_codigo = ?codigo";
        objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?salario", funcionario.Salario));
            objCommand.Parameters.Add(Mapped.Parameter("?cracha", funcionario.Cracha));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", funcionario.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_funcionario WHERE fun_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }


    }
}