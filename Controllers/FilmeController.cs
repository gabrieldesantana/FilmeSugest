using FilmeSugest.Models;
using FilmeSugest.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace FilmeSugest.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IFilmeRepositorio _filmeRepositorio;

        public FilmeController(IFilmeRepositorio filmeRepositorio) //ctor da class
        {
            _filmeRepositorio = filmeRepositorio;
        }

        public IActionResult Index()
        {
            List<FilmeModel> filmes = _filmeRepositorio.BuscarTodos();
            return View(filmes);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            FilmeModel filme = _filmeRepositorio.ListarPorId(id);
            return View(filme);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            FilmeModel contato = _filmeRepositorio.ListarPorId(id);
            return View(contato);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(FilmeModel filme) 
        { 
            _filmeRepositorio.Adicionar(filme);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(FilmeModel filme)
        {
            _filmeRepositorio.Atualizar(filme);
            return RedirectToAction("Index");
        }

        public IActionResult Apagar(int id)
        {
            _filmeRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }



    }
}
