using System.Collections.Generic;
using DataAccess;

namespace BusinessLayer.Repository
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
    }
}
