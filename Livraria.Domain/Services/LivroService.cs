using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces.Repository;
using Livraria.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Livraria.Domain.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _LivroRepository;

        public LivroService(ILivroRepository LivroRepository)
            : base(LivroRepository)
        {
            _LivroRepository = LivroRepository;
        }

        public IEnumerable<Livro> BuscasPorTitulo(string titulo)
        {
            return _LivroRepository.BuscasPorTitulo(titulo);
        }
    }
}
