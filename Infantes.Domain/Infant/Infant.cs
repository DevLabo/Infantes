using Infantes.Domain.Enums;
using Infantes.Domain.ValueObjects;
using System;

namespace Infantes.Domain
{
    public class Infant : IEntity
    {
        public Infant()
        {

        }
        public Infant(string name, DateTime birthdate, Metric metric, Sex sex)
        {
            Name = name;
            Birthdate = birthdate;
            InfantMetric = metric;
            Sex = sex;
        } 

        public int Id { get; private set; }
        public string Name { get; private set; }
        public Sex Sex { get; private set; }
        public DateTime Birthdate { get; private set; }
        public Metric InfantMetric { get; private set; }

        public void ChangeName(string name)
        {
            Name = name;
        }
        public void ChangeSex(Sex sex)
        {
            Sex = sex;
        }

        public void ChangeBirthdate(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public void ChangeMetric(Metric metric)
        {
            InfantMetric = metric;
        }
    }
}
