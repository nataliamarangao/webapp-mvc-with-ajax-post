using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAWithAjaxPost.WebApp.Controllers
{
    public class ConteudoController : Controller
    {
        // GET: Conteudo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConteudoPorCategoria()
        {
            return View();
        }
    }
}