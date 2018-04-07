using Livraria.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Livraria.Infra.Data.EntityConfig
{
    public class LivrariaConfiguration : EntityTypeConfiguration<Livro>
    {
        public LivrariaConfiguration()
        {
            HasKey(x => x.LivroId);

            Property(x => x.Titulo)
                .IsRequired()
                .HasMaxLength(150);

            Property(x => x.SubTitulo)
                .HasMaxLength(150);

            Property(x => x.Autor)
                .IsRequired()
                .HasMaxLength(150);

            Property(x => x.Editora)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
