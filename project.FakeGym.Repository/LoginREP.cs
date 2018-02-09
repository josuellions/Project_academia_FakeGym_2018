using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.FakeGym.DataAccess;
using project.FakeGym.Model;

namespace project.FakeGym.Repository
{
    public class LoginREP
    {
        private ADO _ado = new ADO();

        public LoginMOD Login(LoginMOD dados)
        {
            var usuario = new LoginMOD();
            String _strSql = $@"SELECT * FROM tbAluno
                                WHERE nome_aluno = '{dados.nome_aluno}'
                                AND senha_aluno = '{dados.senha_aluno}'";

            var registro = _ado.RetornoTabela(_strSql);

            if(registro.Rows.Count > 0)
            {
                usuario.id_aluno = Convert.ToInt32(registro.Rows[0]["id_aluno"]);
                usuario.nome_aluno = registro.Rows[0]["nome_aluno"].ToString();
            }
            else
            {
                usuario.id_aluno = 0;
            }

            return usuario;
        }
    }
}
