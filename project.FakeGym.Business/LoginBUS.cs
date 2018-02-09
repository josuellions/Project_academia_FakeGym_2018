using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.FakeGym.Repository;
using project.FakeGym.Model;

namespace project.FakeGym.Business
{
    public class LoginBUS
    {
        private LoginREP _rep = new LoginREP();

        public LoginMOD Login(LoginMOD dados)
        {
            var registro = _rep.Login(dados);

            if(registro.id_aluno == 0)
            {
                throw new Exception("Nome do Aluno ou Senha não confere!");
            }
            else
            {
                return registro;
            }
        }
    }
}
