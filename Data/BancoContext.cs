using FilmeSugest.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeSugest.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options)
        {
        }

        public DbSet<FilmeModel> Filmes { get; set; }
    }
}
