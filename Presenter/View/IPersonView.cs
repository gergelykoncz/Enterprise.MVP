using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer.Dto;

namespace Presenter.View
{
    public interface IPersonView
    {
        IEnumerable<PersonDto> Persons { set; } 
    }
}
