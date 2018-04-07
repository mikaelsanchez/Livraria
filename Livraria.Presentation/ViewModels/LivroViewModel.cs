

using System;
using System.ComponentModel.DataAnnotations;
namespace Livraria.Presentation.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage="Campo Código Obrigatório")]
        [MinLength(2, ErrorMessage="Minimo {0} caracteres")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Campo Titulo Obrigatório")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Titulo { get; set; }

        public string SubTitulo { get; set; }

        [Required(ErrorMessage = "Campo Autor Obrigatório")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Campo Editora Obrigatório")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Campo Ano Obrigatório")]
        public int Ano { get; set; }
        public int Edicao { get; set; }

        [Required(ErrorMessage = "Campo Quantidade Obrigatório")]
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}