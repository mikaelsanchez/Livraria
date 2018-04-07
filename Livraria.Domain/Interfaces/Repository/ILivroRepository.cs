
using Livraria.Domain.Entities;
using System.Collections.Generic;
namespace Livraria.Domain.Interfaces.Repository
{
    public interface ILivroRepository : IRepositoryBase<Livro>
    {
        IEnumerable<Livro> BuscasPorTitulo(string titulo);
    }
}
