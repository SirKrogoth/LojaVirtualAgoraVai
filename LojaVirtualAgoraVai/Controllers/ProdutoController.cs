using LojaVirtualAgoraVai.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtualAgoraVai.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Visualizar()
        {
            Produto produto = GetProduto();

            return View(produto);

            //return new ContentResult() { Content = "<h3>Loja Agora vai . com</h3>", ContentType="text/html"};
        }

        public Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Caneca personalizada",
                Descricao = "Caneca full hd",
                Valor = 15.99
            };
        }
    }
}
