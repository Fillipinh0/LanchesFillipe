using LanchesFillipe.Context;
using LanchesFillipe.Models;
using LanchesFillipe.Repositories.Interfaces;

namespace LanchesFillipe.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;

    }
}
