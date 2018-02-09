using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using project.FakeGym.Business;
using project.FakeGym.Model;

namespace project.FakeGym.UI.MVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Aluno
        private TreinoBUS _negocioTreino = new TreinoBUS();

        private alunoBUS _negocioAluno = new alunoBUS();

        public ActionResult CadastroAluno()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View("../Login/Login");
        }

        //public ActionResult Listar()
        //{
        //    return View(_negocioTreino.Listar());
        //}

        public ActionResult Listar()
        {
            return View("../Aluno/VisualizarTreino");
        }

        public ActionResult Sair()
        {
            //Remover Session
            Session.Remove("id_aluno");
            Session.Remove("nome_aluno");

            //Limpar e Sair
            Session.Abandon();
            return RedirectToAction("../Home/Index");
        }

        [HttpPost]
        public ActionResult CadastroAluno(FormCollection dados)
        {
            var novoaluno = new alunoMOD();
            String senha = Crypto.Hash(dados["senha_aluno"]);


            //var dtBase = Convert.ToString( DateTime.Now);
            //var dtCadastro = Convert.ToString( dados["dtNasc_aluno"]);
            //TempData.Add("Erro", dtBase.Trim(new Char[] { '/', '*', ' ' }));
            ////var verificaDt = ( Convert.ToDecimal( dtBase ) ) - ( Convert.ToDecimal(dtCadastro));

            ////if (verificaDt >= 18)
            ////{
            novoaluno.nome_aluno = dados["nome_aluno"];
            novoaluno.sobrenome_aluno = dados["sobrenome_aluno"];
            novoaluno.dtNasc_aluno = Convert.ToString(dados["dtNasc_aluno"]);
            novoaluno.nome_professor = dados["nome_professor"];
            novoaluno.nome_academia = dados["nome_academia"];
            novoaluno.senha_aluno = senha;
            novoaluno.status_aluno = 1;

            _negocioAluno.CadastroAluno(novoaluno);
            //}
            //else
            //{
            //    TempData.Add("Erro", "Para realizar cadastro, idade deve ser maior que 18 anos!!!");
            //    return Login();
            //}

            return Login();
        }
    }
}