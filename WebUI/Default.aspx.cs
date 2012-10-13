using System;
using System.Collections.Generic;
using Ninject;
using Presenter;
using Presenter.View;

namespace WebUI
{
    public partial class _Default : System.Web.UI.Page, IPersonView
    {
        [Inject]
        public PersonPresenter Presenter { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Presenter.Init(this);
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            Presenter.SearchPersons(tbox_name.Text);
        }

        public IEnumerable<BusinessLayer.Dto.PersonDto> Persons
        {
            set
            {
                grid_persons.DataSource = value;
                grid_persons.DataBind();
            }
        }
    }
}
