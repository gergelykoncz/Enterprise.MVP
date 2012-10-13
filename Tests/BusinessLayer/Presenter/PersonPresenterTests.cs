using System.Collections.Generic;
using BusinessLayer.Dto;
using BusinessLayer.Facade;
using Moq;
using NUnit.Framework;
using Presenter;
using Presenter.View;

namespace Tests.BusinessLayer.Presenter
{
    [TestFixture]
    public class PersonPresenterTests
    {
        [Test]
        public void InitCallsFacadeToGetPersons()
        {
            var facade = new Mock<IPersonFacade>();
            var presenter = new PersonPresenter(facade.Object);
            var view = new Mock<IPersonView>();
            presenter.Init(view.Object);
            facade.Verify(x => x.GetAllPersons(), Times.Once());
        }

        [Test]
        public void PersonsPassedToView()
        {
            var facade = new Mock<IPersonFacade>();
            var presenter = new PersonPresenter(facade.Object);
            var view = new Mock<IPersonView>();
            presenter.Init(view.Object);
            view.VerifySet(x => x.Persons = It.IsAny<IEnumerable<PersonDto>>(), Times.Once());
        }

        [Test]
        public void SearchByNameCallsFacadeMethodWithAppropriateParameters()
        {
            var facade = new Mock<IPersonFacade>();
            var presenter = new PersonPresenter(facade.Object);
            var view = new Mock<IPersonView>();
            presenter.Init(view.Object);
            presenter.SearchPersons("query");
            facade.Verify(x => x.GetPersonsWithName("query"), Times.Once());
        }

        [Test]
        public void SearchByNameUpdatesView()
        {
            var facade = new Mock<IPersonFacade>();
            var presenter = new PersonPresenter(facade.Object);
            var view = new Mock<IPersonView>();
            presenter.Init(view.Object);
            presenter.SearchPersons("query");
            view.VerifySet(x => x.Persons = It.IsAny<IEnumerable<PersonDto>>(), Times.Exactly(2));
        }
    }
}
