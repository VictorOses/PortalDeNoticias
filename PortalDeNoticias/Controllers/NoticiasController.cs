using PortalDeNoticias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDeNoticias.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: Noticias
        public ActionResult Index()
        {
            return View(RepositorioNoticias.Noticias);
        }

        public ActionResult Detalhes(int id)
        {
            var noticia = RepositorioNoticias.Noticias.FirstOrDefault(n => n.Id == id);
            return View(noticia);
        }
    }
}