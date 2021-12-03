using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kokedamas_e_TuperWares.Models;
using System.Data.Entity;
using Kokedamas_e_TuperWares.Conexao;


namespace Kokedamas_e_TuperWares.Controllers
{
    public class TipoController : Controller
    {
        private ConnContext db = new ConnContext();

        // GET: Tipo
        public ActionResult Index()
        {
            return View(db.tipodb.ToList());
        }
        public ActionResult TipoCadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TipoCadastro(Tipo tiporef)
        {
            db.tipodb.Add(tiporef);
            db.SaveChanges();
            return RedirectToAction("Index");
            
  
        }

    }
}