using atendecidadao.Services;
using atendecidadao.Models;


namespace atendecidadao.Controllers
{
    public class AnexosController : BaseController<Anexo, IAnexoService>
    {
      
        public AnexosController(IAnexoService service) : base(service)
        {
        }    
       
    }
}
