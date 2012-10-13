using BusinessLayer.Dto;
using DataAccess;

namespace BusinessLayer.Builder
{
    public class PersonDtoBuilder : IPersonDtoBuilder
    {
        public PersonDto BuildDto(Person fromPerson)
        {
            return new PersonDto() { Name = fromPerson.Name };
        }
    }
}
