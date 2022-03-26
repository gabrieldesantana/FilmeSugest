using FilmeSugest.Data;
using FilmeSugest.Models;

namespace FilmeSugest.Repositorio
{
    public class FilmeRepositorio : IFilmeRepositorio
    {
        private BancoContext _bancoContext;

        public FilmeRepositorio(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }

        public FilmeModel ListarPorId(int id)
        {
            return _bancoContext.Filmes.FirstOrDefault(x => x.Id == id);

        }

        public List<FilmeModel> BuscarTodos()
        {
            return _bancoContext.Filmes.ToList();
        }


        public FilmeModel Adicionar(FilmeModel filme)
        {
            _bancoContext.Filmes.Add(filme);
            _bancoContext.SaveChanges();
            return filme;
        }

        public FilmeModel Atualizar(FilmeModel filme)
        {
            FilmeModel filmeDB = ListarPorId(filme.Id);

            if (filmeDB == null) throw new System.Exception("Houve um erro na atualizacao do contato!");

            filmeDB.Nome = filme.Nome; //O dado que tá no banco é substituido pelo da model
            filmeDB.Genero = filme.Genero;
            filmeDB.Ano = filme.Ano;

            _bancoContext.Filmes.Update(filmeDB);
            _bancoContext.SaveChanges();
            return filmeDB;
        }

        public bool Apagar(int id)
        {
            FilmeModel filmeDB = ListarPorId(id);

            if (filmeDB == null) throw new System.Exception("Houve um erro no momento da Exclusão");

            _bancoContext.Filmes.Remove(filmeDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
