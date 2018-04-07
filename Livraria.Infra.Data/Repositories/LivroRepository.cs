using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> BuscasPorTitulo(string titulo)
        {
            return Db.Livros.Where(x => x.Titulo.Contains(titulo));
        }
    }
}
