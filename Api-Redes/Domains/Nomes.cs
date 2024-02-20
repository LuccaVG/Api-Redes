using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Redes.Domains
{
    [Table("Nomes")]
    public class Nomes
    {
        [Key]
        public Guid IdNomes { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="Nome Obrigatório!")]
        public string Name { get; set; }
    }
}
