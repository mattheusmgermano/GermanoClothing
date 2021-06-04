using GermanoClothing.Models;
using System.Collections.Generic;

namespace GermanoClothing.Repositories
{
    public interface IProductRepository
    {
        void Produtificar(List<Roupa> _roupas);
        IList<Produto> GetProdutos(); 
    }
}