using atendecidadao.Data;
using atendecidadao.Models;
using Microsoft.EntityFrameworkCore;

namespace atendecidadao.Repositories
{
    public interface ISolicitacaoRepository : IRepository<Solicitacao> {
        
    }
    
    public class SolicitacaoRepository : Repository<Solicitacao, ApiDbContext>, ISolicitacaoRepository
    {
        public SolicitacaoRepository(ApiDbContext context) : base(context) { }     
           
        
    }
}
