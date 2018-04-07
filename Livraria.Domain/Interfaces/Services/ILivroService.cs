

using Livraria.Domain.Entities;
using System.Collections.Generic;
namespace Livraria.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> BuscasPorTitulo(string titulo);
    }
}
