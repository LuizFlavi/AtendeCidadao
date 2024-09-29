using System.ComponentModel.DataAnnotations;

namespace atendecidadao.Models
{
    public class Solicitacao: BaseEntity
    {

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public StatusSolicitacao Status { get; set; } = StatusSolicitacao.Pendente;
    }

    public enum StatusSolicitacao
    {
        Pendente = 0,
        EmAndamento = 1,
        Concluida = 2,
        Cancelada = 3
    }
}


