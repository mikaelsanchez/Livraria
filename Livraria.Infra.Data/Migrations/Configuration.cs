namespace Livraria.Infra.Data.Migrations
{
    using Livraria.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.LivrariaContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.LivrariaContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            IList<Livro> lstLivros = new List<Livro>();

            lstLivros.Add(new Livro() { Titulo = "as",SubTitulo="old", Autor = "as", Ano = 1, Edicao = 1, Editora = "as",Quantidade=1 });
            lstLivros.Add(new Livro() { Titulo = "as",SubTitulo="old", Autor = "as", Ano = 2, Edicao = 2, Editora = "ss" , Quantidade=3});
            lstLivros.Add(new Livro() { Titulo = "as", Autor = "as", Ano = 3, Edicao = 3, Editora = "cc", Quantidade = 4 });

            foreach (var item in lstLivros)
                context.Livros.Add(item);

            base.Seed(context);
        }
    }
}
