using Infantes.Database;
using Infantes.Domain;
using Infantes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;

namespace Infantes.Application
{
    public class InfantService : IInfantService
    {
        private readonly IInfantRepository _infantRepository;
        public InfantService(IInfantRepository infantRepository)
        {
            _infantRepository = infantRepository;
        }

        public InfantModel CreateInfant(InfantModel infantModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InfantModel> GetAllInfant()
        {
            return _infantRepository.GetAll().Select(InfantExpression.InfantModel).ToList();
        }

        public InfantModel GetInfant(int id)
        {
            throw new NotImplementedException();
        }
    }

    public static class InfantExpression
    {
        public static Expression<Func<Infant, InfantModel>> InfantModel => Infant => new InfantModel
        {
            Id = Infant.Id,
            Name = Infant.Name,
            Length = Infant.InfantMetric.Length,
            Perimeter = Infant.InfantMetric.Perimeter,
            Weight = Infant.InfantMetric.Weight,
        };
    }
}