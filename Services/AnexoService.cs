using atendecidadao.Data;
using atendecidadao.Models;
using atendecidadao.Repositories;


namespace atendecidadao.Services
{
    public interface IAnexoService : IService<Anexo> {
    }

    public class AnexoService : Service<Anexo, ApiDbContext>, IAnexoService
    {       
        public AnexoService(IAnexoRepository repository) : base(repository)
        {
        }
        
    }
}
