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
    public class HomeController : Controller
    {
        private TreinoBUS _negocioTreino = new TreinoBUS();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View("/Aluno/Login");
        }

        public ActionResult Listar()
        {
            return View(_negocioTreino.Listar());
        }

        public ActionResult CadastroAluno()
        {
            return View("/Aluno/CadastroAluno");
        }

        public ActionResult Sair()
        {
            //Remover Session
            Session.Remove("id_aluno");
            Session.Remove("nome_aluno");

            //Limpar e Sair
            Session.Abandon();

            return View("Index");
        }
    }
}