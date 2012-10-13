using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Builder;
using BusinessLayer.Dto;
using BusinessLayer.Facade;
using BusinessLayer.Repository;
using DataAccess;
using Moq;
using NUnit.Framework;

namespace Tests.BusinessLayer.Facade
{
    [TestFixture]
    public class PersonFacadeTests
    {
        private List<Person> _persons = new List<Person>();
        private PersonFacade _facade;

        [SetUp]
        public void SetUp()
        {
            _persons.Add(new Person() { ID = 1, Name = "User1" });
            _persons.Add(new Person() { ID = 2, Name = "User2" });
            _persons.Add(new Person() { ID = 3, Name = "User3" });

            var repository = new Mock<IPersonRepository>();
            repository.Setup(x => x.GetAll()).Returns(_persons.AsEnumerable());
            var builder = new Mock<IPersonDtoBuilder>();
            builder.Setup(x => x.BuildDto(It.IsAny<Person>())).Returns((Person p) => new PersonDto() { Name = p.Name });
            _facade = new PersonFacade(repository.Object, builder.Object);
        }

        [Test]
        public void GetAllPersonsReturnsFromRepository()
        {
            List<PersonDto> result = _facade.GetAllPersons().ToList();

            Assert.AreEqual(_persons.Count, result.Count);
        }
    }
}
