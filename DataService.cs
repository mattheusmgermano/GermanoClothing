using GermanoClothing.Models;
using GermanoClothing.Repositories;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GermanoClothing
{
    class DataService : IDataService
    {
        private readonly ApplicationContext _context;
        private readonly IProductRepository _produto;

        public DataService(ApplicationContext context, IProductRepository produto)
        {
            _context = context;
            _produto = produto;
        }
        public void StartDB()
        {
            _context.Database.EnsureCreated();

            List<Roupa> _roupas = GetRoupas();

            _produto.Produtificar(_roupas);
        }

        private static List<Roupa> GetRoupas()
        {
            var json = File.ReadAllText("roupas.json");
            var _roupas = JsonConvert.DeserializeObject<List<Roupa>>(json);
            return _roupas;
        }
    }
    public class Roupa
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
