using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Builder;
using BusinessLayer.Dto;
using BusinessLayer.Repository;

namespace BusinessLayer.Facade
{
    public class PersonFacade : IPersonFacade
    {
        private readonly IPersonRepository _repository;
        private readonly IPersonDtoBuilder _dtoBuilder;

        public PersonFacade(IPersonRepository repository,
            IPersonDtoBuilder dtoBuilder)
        {
            this._repository = repository;
            this._dtoBuilder = dtoBuilder;
        }

        public IEnumerable<PersonDto> GetAllPersons()
        {
            return _repository.GetAll().Select(x => _dtoBuilder.BuildDto(x));
        }
    }
}
