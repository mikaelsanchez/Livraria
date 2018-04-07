using Livraria.Application.Interface;
using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces.Services;
using Livraria.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application
{
    public class LivroAppService  : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService)
            : base(livroService)
        {
            _livroService = livroService;
        }
    
    }
}
