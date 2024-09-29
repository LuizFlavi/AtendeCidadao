using System.ComponentModel.DataAnnotations;

namespace atendecidadao.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}