using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kokedamas_e_TuperWares.Conexao;
using Kokedamas_e_TuperWares.Models;
using Kokedamas_e_TuperWares.Controllers;

namespace Kokedamas_e_TuperWares.Controllers
{
    public class ModeloController : Controller
    {
        private ConnContext db = new ConnContext();

        // GET: Modelo
        public ActionResult Index() 
        {
            return View(db.Modelodb.ToList());
        }
        public ActionResult ModeloCadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ModeloCadastro(Modelo Modeloref)
        {
            db.Modelodb.Add(Modeloref);
            db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}
