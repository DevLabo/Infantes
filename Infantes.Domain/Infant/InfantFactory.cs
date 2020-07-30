using Infantes.Domain.Enums;
using Infantes.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Infantes.Domain
{
    public static class InfantFactory
    {
        public static Infant GetNewInfantObject(
            string name,
            DateTime birthdate,
            decimal perimeter,
            decimal lenght,
            decimal weight,
            Sex sex)
        {
            var metric = new Metric(perimeter, lenght, weight);
            return new Infant(name, birthdate, metric, sex);
        }
    }
}
