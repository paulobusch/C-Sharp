using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarregaMaisMVC.Controllers
{
    public class HomeController : Controller
    {
        const int _tamBloco = 2;
        List<ProdutoModel> _lista = new List<ProdutoModel>()
        {
            new ProdutoModel(){nome = "Notebook vaio Fit 15", imagem = "notebook_vaio.jpg", preco = 3449.90m},
            new ProdutoModel(){nome = "Notebook DELL Inspirion 14", imagem = "notebook_dell.jpg", preco = 2615.8m},
            new ProdutoModel(){nome = "Celular Apple iPhone 5S", imagem = "celular_apple_iphone_5s.png", preco = 3500},
            new ProdutoModel(){nome = "Celular Samsung Galaxy S7", imagem = "celular-smartphone-samsung-galaxy-s7.jpg", preco = 3330},
            new ProdutoModel(){nome = "Tv LG 43", imagem = "Tv-LG.jpg", preco = 4500}
        };

        private List<ProdutoModel> ObterBlocoProduto(int bloco)
        {
            var posInicial = _tamBloco * (bloco -1);
            return _lista.Skip(posInicial).Take(_tamBloco).ToList();
           
        }
        public ActionResult Index()
        {
            return View(ObterBlocoProduto(1));
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

        private string CarregarListaProduto(List<ProdutoModel> lista)
        {
            var ret = string.Empty;
            if (lista != null && lista.Count > 0)
            {
                foreach (var prod in lista)
                {
                    ret += string.Format(
                    "<div class='col-md-6'>" +
                    "<h2>{0}</h2>" +
                    "<p>{1}</p>" +
                    "<img src = '/img/{2}' alt='' style='width: 300px; height: 300px' />" +
                    "</div>", prod.nome, prod.preco.ToString("C"), prod.imagem);
                }
            }
            return ret;
        }

        [HttpPost]
        public ActionResult CarregarBlocoProduto(int bloco)
        {
            var listaProduto = ObterBlocoProduto(bloco);
            return Json(CarregarListaProduto(listaProduto));
        }
    }
}