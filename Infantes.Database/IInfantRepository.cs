using Infantes.Domain;
using System.Linq;

namespace Infantes.Database
{
    public interface IInfantRepository : IRepository<Infant>
    {
        IQueryable<Infant> GetInfantPaginated(int page, int size);
    }
}
