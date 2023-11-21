using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace biblioteca.Models
{
    public class Autor
    {
        [Column("AutorId")]
        [Display(Name = "Código do autor")]
        public int Id { get; set; }

        [Column("NomeAutor")]
        [Display(Name = "Autor")]
        public string NomeAutor { get; set; } = string.Empty;
    }
}
