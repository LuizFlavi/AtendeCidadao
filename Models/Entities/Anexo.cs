using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atendecidadao.Models
{

    [Table("Anexos")]
    public class Anexo: BaseEntity
    {

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }  
             
    }
    
}


