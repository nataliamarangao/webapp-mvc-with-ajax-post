using SPAWithAjaxPost.WebApp.Models;
using SPAWithAjaxPost.WebApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAWithAjaxPost.WebApp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            
            return View(Conteudo.Todos());
        }

        public ActionResult Filtrar()
        {

            return View(new Cliente());
        }

        [HttpGet]
        public JsonResult CarregarCidades(UnidadeFederacao UF)
        {
            var cidade = RepositorioCidade.ObterTodos().Where(x => x.UF == UF);

            return Json(cidade.ToList().AsQueryable<Cidade>(), JsonRequestBehavior.AllowGet);
        }

    }
}