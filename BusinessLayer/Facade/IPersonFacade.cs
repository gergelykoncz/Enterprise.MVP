using System.Collections.Generic;
using DataAccess;
using BusinessLayer.Dto;

namespace BusinessLayer.Facade
{
    public interface IPersonFacade
    {
        IEnumerable<PersonDto> GetAllPersons();
        IEnumerable<PersonDto> GetPersonsWithName(string name);
    }
}
