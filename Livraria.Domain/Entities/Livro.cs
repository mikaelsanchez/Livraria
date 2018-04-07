using System;

namespace Livraria.Domain.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Ano { get; set; }
        public int Edicao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}
