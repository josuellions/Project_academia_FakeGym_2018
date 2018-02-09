using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.FakeGym.Repository;
using project.FakeGym.Model;

namespace project.FakeGym.Business
{
    public class alunoBUS
    {
        private alunoREP _rep = new alunoREP();

        public void CadastroAluno(alunoMOD dados)
        {
            _rep.CadastroAluno(dados);
        }
    }
}
