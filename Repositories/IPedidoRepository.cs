using GermanoClothing.Models;

namespace GermanoClothing.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
}
