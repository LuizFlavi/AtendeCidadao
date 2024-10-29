using atendecidadao.Data;
using atendecidadao.Models;
using Microsoft.EntityFrameworkCore;

namespace atendecidadao.Repositories
{
    public interface IAnexoRepository : IRepository<Anexo> {
        
    }
    
    public class AnexoRepository : Repository<Anexo, ApiDbContext>, IAnexoRepository
    {
        public AnexoRepository(ApiDbContext context) : base(context) { }     
           
        
    }
}
