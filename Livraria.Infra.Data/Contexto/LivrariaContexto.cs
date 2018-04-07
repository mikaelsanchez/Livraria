using Livraria.Domain.Entities;
using Livraria.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Livraria.Infra.Data.Contexto
{
    public class LivrariaContexto : DbContext
        
    {
        public LivrariaContexto()
            : base("LivrariaConnection")
        {

        }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(x => x.Name == x.ReflectedType.Name + "Id")
                .Configure(x => x.IsKey());

            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(x => x.HasMaxLength(100));

            modelBuilder.Configurations.Add(new LivrariaConfiguration());


        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (item.State == EntityState.Added)
                {
                    item.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (item.State == EntityState.Modified)
                {
                    item.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }

}
