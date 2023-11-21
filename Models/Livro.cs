using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace biblioteca.Models
{
    public class Livro
    {
        [Column("LivroId")]
        [Display(Name = "Código do livro")]
        public int Id { get; set; }

        [Column("TituloLivro")]
        [Display(Name = "Titulo do livro")]
        public string TituloLivro { get; set; } = string.Empty;

        [ForeignKey("GeneroId")]
        [Display(Name = "Gênero")]
        public int IdGenero { get; set; }

        [ForeignKey("AutorId")]
        [Display(Name = "Autor")]
        public int AutorId { get; set; }

        [Column("QuantidadeLivro")]
        [Display(Name = "Quantidade de livro")]
        public int QuantidadeLivro { get; set; }
    }
}
