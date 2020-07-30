using AutoFixture;
using FluentAssertions;
using Infantes.Domain.Enums;
using Infantes.Domain.ValueObjects;
using Moq;
using System;
using Xunit;

namespace Infantes.Domain.UnitTest
{
    public class InfantTest
    {
        
        [Fact]
        public void When_Create_Infant_From_Factory_Get_New_Infant()
        {
            var fixture = new Fixture();

            var name = fixture.Create<string>();
            var birthdate = fixture.Create<DateTime>();
            var metric = fixture.Create<Metric>();
            var sex = fixture.Create<Sex>();

            var expected = new Infant(name, birthdate, metric, sex);

            var result = InfantFactory.GetNewInfantObject(
                name, birthdate, metric.Perimeter, metric.Length, metric.Weight, sex);

            result.Should().BeEquivalentTo(expected);
        }


    }
}
