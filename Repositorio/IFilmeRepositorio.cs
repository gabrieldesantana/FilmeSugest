using FilmeSugest.Models;

namespace FilmeSugest.Repositorio
{
    public interface IFilmeRepositorio
    {
        List<FilmeModel> BuscarTodos();

        FilmeModel Adicionar(FilmeModel filme);

        FilmeModel ListarPorId(int id);

        FilmeModel Atualizar(FilmeModel filme);

        bool Apagar(int id);
    }
}
