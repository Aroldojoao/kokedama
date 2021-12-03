using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kokedamas_e_TuperWares.Models;
using Kokedamas_e_TuperWares.Conexao;
using System.Data.Entity;

namespace Kokedamas_e_TuperWares.Controllers
{
    public class HomeController : Controller
    {

        private ConnContext db = new ConnContext();

        // GET: Formularios

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FormularioCadastro()
        {
            return View();
        }

        [HttpPost]

        public ActionResult FormularioCadastro(Kokedama koke)
            {
                db.kokedamasdb.Add(koke);
                db.SaveChanges();
                return RedirectToAction("FormularioConsulta");
            }

            public ActionResult FormularioConsulta()
            {
                return View(db.kokedamasdb.ToList());
            }


        }
    }