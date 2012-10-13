using BusinessLayer.Facade;
using Presenter.View;
using Presenter.Base;

namespace Presenter
{
    public class PersonPresenter : PresenterBase<IPersonView>
    {
        private readonly IPersonFacade _facade;

        public PersonPresenter(IPersonFacade facade)
        {
            this._facade = facade;
        }

        public void SearchPersons(string name)
        {
            View.Persons = _facade.GetPersonsWithName(name);
        }

        protected override void Init()
        {
            View.Persons = _facade.GetAllPersons();
        }
    }
}
