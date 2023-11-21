using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace biblioteca.Models
{
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código do usuário")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do usuário")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("RmUsuario")]
        [Display(Name = "Rm do usuário")]
        public string RmUsuario { get; set; } = string.Empty;
    }
}
