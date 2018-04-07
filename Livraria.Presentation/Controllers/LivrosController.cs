using AutoMapper;
using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces.Services;
using Livraria.Presentation.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace Livraria.Presentation.Controllers
{
    public class LivrosController : Controller
    {

        private readonly ILivroService _livroService;

        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }


        // GET: Livros
        public ActionResult Index()
        {
            var LivroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroService.GetAll().OrderBy(x => x.Titulo));
            return View(LivroViewModel);
        }

        // GET: Livros/Details/5
        public ActionResult Details(int id)
        {
            var Livro = _livroService.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            return View(LivroViewModel);
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroViewModel Livro)
        {
            if (ModelState.IsValid)
            {
                var LivroDomain = Mapper.Map<LivroViewModel, Livro>(Livro);
                _livroService.Add(LivroDomain);

                return RedirectToAction("Index");
            }

            return View(Livro);
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
            var Livro = _livroService.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            return View(LivroViewModel);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LivroViewModel Livro)
        {
            if (ModelState.IsValid)
            {
                var LivroDomain = Mapper.Map<LivroViewModel, Livro>(Livro);
                _livroService.Update(LivroDomain);

                return RedirectToAction("Index");
            }

            return View(Livro);
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
            var Livro = _livroService.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            return View(LivroViewModel);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Livro = _livroService.GetById(id);
            _livroService.Remove(Livro);

            return RedirectToAction("Index");
        }
    }
}
