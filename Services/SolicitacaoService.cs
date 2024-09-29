using atendecidadao.Data;
using atendecidadao.Models;
using atendecidadao.Repositories;


namespace atendecidadao.Services
{
    public interface ISolicitacaoService : IService<Solicitacao> {
    }

    public class SolicitacaoService : Service<Solicitacao, ApiDbContext>, ISolicitacaoService
    {       
        public SolicitacaoService(ISolicitacaoRepository repository) : base(repository)
        {
        }
        
    }
}
