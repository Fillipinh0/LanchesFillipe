using LanchesFillipe.Models;

namespace LanchesFillipe.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
