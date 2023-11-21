using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace biblioteca.Models
{
    public class Emprestimo
    {
        [Column("EmprestimoId")]
        [Display(Name = "Código do emprestimo")]
        public int Id { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]
        public int IdUsuario { get; set; }

        [ForeignKey("LivroId")]
        [Display(Name = "Livro")]
        public int IdLivro { get; set; }

        [Column("DataInicioEmprestimo")]
        [Display(Name = "Data do inicio")]
        public DateTime DataInicioEmprestimo { get; set; }

        [Column("DataFimEmprestimo")]
        [Display(Name = "Data do fim")]
        public DateTime DataFimEmprestimo { get; set; }

        [Column("StatusEmprestimo")]
        [Display(Name = "Status do emprestimo")]
        public bool StatusEmprestimo { get; set; }
    }
}
