using BusinessLayer.Builder;
using BusinessLayer.Dto;
using DataAccess;
using NUnit.Framework;

namespace Tests.BusinessLayer.Builder
{
    [TestFixture]
    public class PersonDtoBuilderTests
    {
        [Test]
        public void BuiderSetsNameOfDtoToEntitys()
        {
            var person = new Person();
            person.Name = "Person with unique name";

            var builder = new PersonDtoBuilder();
            PersonDto dto = builder.BuildDto(person);
            Assert.AreEqual(person.Name, dto.Name);
        }
    }
}
