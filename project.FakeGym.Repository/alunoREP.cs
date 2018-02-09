using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.FakeGym.DataAccess;
using project.FakeGym.Model;


namespace project.FakeGym.Repository
{
    public class alunoREP
    {
        private ADO _ado = new ADO();

        public void CadastroAluno(alunoMOD dados)
        {
            String _strSql = $@"INSERT INTO tbAluno
                               (nome_aluno, sobrenome_aluno, dtNasc_aluno, nome_professor, nome_academia, senha_aluno, status_aluno)
                                VALUES('{dados.nome_aluno}','{dados.sobrenome_aluno}','{dados.dtNasc_aluno}',
                                        '{dados.nome_professor}','{dados.nome_academia}',
                                        '{dados.senha_aluno}','{dados.status_aluno}')";

            _ado.ExecutarCommando(_strSql);
        }
    }
}
