using BancoDomain.Entity;
using BancoWeb.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancoWeb.Controllers
{
    public class ContaCorrenteController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();


        public ActionResult Listar()
        {
            var lista = _unit.ContaCorrenteRepository.Listar();
            return View(lista);
        }


        public ActionResult Cadastrar(ContaCorrente cc) 
        {
            _unit.ContaCorrenteRepository.Cadastrar(cc);
            _unit.Save();
            return RedirectToAction("Listar");
        }



        // GET: ContaCorrente
        public ActionResult Index()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

    }
}