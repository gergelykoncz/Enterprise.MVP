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

        protected override void Init()
        {
            View.Persons = _facade.GetAllPersons();
        }
    }
}
