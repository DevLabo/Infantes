using Infantes.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infantes.Database
{
    public class InfantRepository : Repository<Infant, InfantContext>, IInfantRepository
    {
        private readonly InfantContext _context;
        public InfantRepository(InfantContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Infant> GetInfantPaginated(int page, int pageSize)
        {
            var result = _context.Infants.Skip(pageSize * page).Take(pageSize);
            return result;
        }
    }
}
