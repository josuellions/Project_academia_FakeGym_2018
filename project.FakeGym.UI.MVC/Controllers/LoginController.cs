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
    public class LoginController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login
        private LoginBUS _negocio = new LoginBUS();

        private TreinoBUS _negocioTreino = new TreinoBUS();

        public ActionResult Login()
        {
            return View("/Login/Login");
        }

        public ActionResult Listar()
        {
            return View("../Aluno/VisualizarTreino", _negocioTreino.Listar());
        }

        //public ActionResult Listar()
        //{
        //    return View("../Aluno/VisualizarTreino");
        //}

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
        public ActionResult Login(FormCollection dados)
        {
            try
            {
                var negocio = new LoginBUS();
                var usuario = new LoginMOD();

                String senha = Crypto.Hash(dados["senha_aluno"]);
                usuario.nome_aluno = dados["nome_aluno"];
                usuario.senha_aluno = senha;

                var registro = negocio.Login(usuario);

                Session.Add("id_aluno", registro.id_aluno);
                Session.Add("nome_aluno", registro.nome_aluno);

            }
            catch (Exception e)
            {
                TempData.Add("Erro", e.Message);
                return View("Login");
            }

            return RedirectToAction("Listar");

        }
    }
}