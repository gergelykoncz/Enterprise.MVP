using System.Collections.Generic;
using BusinessLayer.Dto;

namespace Presenter.View
{
    public interface IPersonView
    {
        IEnumerable<PersonDto> Persons { set; } 
    }
}
