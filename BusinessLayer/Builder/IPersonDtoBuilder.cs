using BusinessLayer.Dto;
using DataAccess;

namespace BusinessLayer.Builder
{
    public interface IPersonDtoBuilder
    {
        PersonDto BuildDto(Person fromPerson);
    }
}
