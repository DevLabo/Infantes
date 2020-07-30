using Infantes.Model;
using System.Collections.Generic;

namespace Infantes.Application
{
    public interface IInfantService
    {
        InfantModel GetInfant(int id);
        IEnumerable<InfantModel> GetAllInfant();
        InfantModel CreateInfant(InfantModel infantModel); 
    }
}
