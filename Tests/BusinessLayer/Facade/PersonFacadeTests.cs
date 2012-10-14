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
        private List<Person> _persons;
        private PersonFacade _facade;

        [SetUp]
        public void SetUp()
        {
            _persons = new List<Person>();
            _persons.Add(new Person() { Id = 1, Name = "FirstUser" });
            _persons.Add(new Person() { Id = 2, Name = "AnotherUser" });
            _persons.Add(new Person() { Id = 3, Name = "ThirdUser" });

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

        [Test]
        public void GetPersonsWithNameReturnsExactMatch()
        {
            List<PersonDto> result = _facade.GetPersonsWithName("FirstUser").ToList();

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("FirstUser", result.Single().Name);
        }

        [Test]
        public void GetPersonsWithNameReturnsPartialMatches()
        {
            List<PersonDto> result = _facade.GetPersonsWithName("User").ToList();
            Assert.AreEqual(3, result.Count);
        }

        [Test]
        public void GetPersonsWithNameIsCaseInsensitive()
        {
            List<PersonDto> result = _facade.GetPersonsWithName("THirdUSER").ToList();
            Assert.AreEqual("ThirdUser", result.Single().Name);
        }
    }
}
