using System;
using System.Collections.Generic;
using DataAccess;

namespace BusinessLayer.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetAll()
        {
            var result = new List<Person>();
            result.Add(new Person() { ID = 1, Name = "User1" });
            return result;
        }
    }
}
