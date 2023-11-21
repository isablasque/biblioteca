using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace biblioteca.Models
{
    public class Genero
    {
        [Column("GeneroId")]
        [Display(Name = "Código do gênero")]
        public int Id { get; set; }

        [Column("NomeGenero")]
        [Display(Name = "Gênero do livro")]
        public string NomeGenero { get; set; } = string.Empty;
    }
}
