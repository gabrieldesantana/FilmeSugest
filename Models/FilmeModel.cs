using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FilmeSugest.Models
{
    public class FilmeModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName ("Nome")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Nome { get; set; }

        [DisplayName("Genero")]
        public string Genero { get; set; }

        [DisplayName("Ano")]
        public int Ano { get; set; }
    }
}
