using atendecidadao.Services;
using atendecidadao.Models;


namespace atendecidadao.Controllers
{
    public class SolicitacoesController : BaseController<Solicitacao, ISolicitacaoService>
    {
      
        public SolicitacoesController(ISolicitacaoService service) : base(service)
        {
        }    
       
    }
}
