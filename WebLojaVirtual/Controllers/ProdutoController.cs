using ClassLojaVirtual.Entitades;
using ClassLojaVirtual.Repositório1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRepositorio _Repositorio;
        // GET: Produto
        public ActionResult Index()
        {


            _Repositorio = new ProdutosRepositorio();
            var produtos = _Repositorio.Produto.Take(3);

            return View(produtos);
        }

        //public string QueDiaEHoje()
        //{
        //    return DateTime.Now.Date.DayOfWeek.ToString();
        //}
    }
}