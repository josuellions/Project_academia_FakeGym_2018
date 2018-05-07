using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace project.FakeGym.DataAccess
{
    public class ADO
    {
        //String _strConn = @"Data Source=DESENVOLWIN10\SQLEXPRESS;Initial Catalog=DBFakeGym;Integrated Security=True;Pooling=False";
        String _strConn = @"Server=EC2AMAZ-T69QNCJ\MSSQLSERVER2017;Database=DBFakeGym;Integrated Security = true";
        public void ExecutarCommando(String sql)
        {
            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = _strConn;
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable RetornoTabela(String sql)
        {
            DataTable tabela = new DataTable();

            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = _strConn;
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sql;

                    using (var da = new SqlDataAdapter())
                    {
                        da.SelectCommand = comando;
                        da.Fill(tabela);
                    }
                }
            }

            return tabela;
        }
    }
}