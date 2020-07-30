using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infantes.Domain.ValueObjects
{
    public class Metric : ValueObject
    {
        public Metric() { }

        public Metric(decimal perimeter, decimal lenght, decimal weight)
        {
            Perimeter = perimeter;
            Length = lenght;
            Weight = weight;
        }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Perimeter { get; private set; }
        public decimal Length { get; private set; }
        public decimal Weight { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Perimeter;
            yield return Length;
            yield return Weight;
        }
    }
}
