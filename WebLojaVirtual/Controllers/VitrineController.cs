using ClassLojaVirtual.Repositório1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLojaVirtual.Controllers
{
    public class VitrineController : Controller
    {
          private ProdutosRepositorio _Repositorio;
          public int ProdutosPorPagina = 3;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _Repositorio = new ProdutosRepositorio();
            var produtos = _Repositorio.Produto.OrderBy(p => p.Descrição)
                .Skip((ProdutosPorPagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);


            return View(produtos);
        }
    }
}