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
            result.Add(new Person() { Id = 1, Name = "First User" });
            result.Add(new Person() { Id = 2, Name = "Second User" });
            result.Add(new Person() { Id = 2, Name = "Third User" });
            return result;
        }
    }
}
