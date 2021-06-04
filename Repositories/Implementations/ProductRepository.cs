using GermanoClothing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GermanoClothing.Repositories.Implementations
{
    public class ProductRepository : BaseRepository<Produto>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context)
        {
        }

        public void Produtificar(List<Roupa> _roupas)
        {
            foreach (var _roupa in _roupas)
            {
                if (!dbSet.Where(p => p.Codigo == _roupa.Codigo).Any())
                {
                dbSet.Add(new Produto(_roupa.Codigo, _roupa.Nome, _roupa.Preco));
                }
            }
            _context.SaveChanges();
        }

        IList<Produto> IProductRepository.GetProdutos()
        {
            return _context.Set<Produto>().ToList();
        }
    }
}
