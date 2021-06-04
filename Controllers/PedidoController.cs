using GermanoClothing.Models;
using GermanoClothing.Repositories;
using GermanoClothing.Repositories.Implementations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GermanoClothing.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProductRepository _produto;
        private readonly IPedidoRepository _pedido;

        public PedidoController(IProductRepository produto, IPedidoRepository pedido)
        {
            _produto = produto;
            _pedido = pedido;
        }

        public IActionResult Carrossel() 
        {
            return View(_produto.GetProdutos());
        }
        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                _pedido.AddItem(codigo);
            }
            Pedido pedido = _pedido.GetPedido();
            return View(pedido.Itens);
        }
        public IActionResult Cadastro(){
            return View();
        }
        public IActionResult Resumo()
        {
            Pedido pedido = _pedido.GetPedido();
            return View(pedido);
        }
    }
}
