using System;
using System.Collections.Generic;
using System.Text;

namespace Infantes.Domain.ValueObjects
{
    public class Metric
    {
        public Metric(decimal perimeter, decimal lenght, decimal weight)
        {
            Perimeter = perimeter;
            Length = lenght;
            Weight = weight;
        }

        public decimal Perimeter { get; private set; }
        public decimal Length { get; private set; }
        public decimal Weight { get; private set; }

        public void ChangePerimeter(decimal perimeter)
        {
            Perimeter = perimeter;
        }

        public void ChangeLenght(decimal lenght)
        {
            Length = lenght;
        }

        public void ChangeWeight(decimal weight)
        {
            Weight = weight;
        }

    }
}
