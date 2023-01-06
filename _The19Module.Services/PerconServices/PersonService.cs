using _19Module.Domain.Enums;
using _19Module.Domain.Interfaces;
using _19Module.Domain.PersonClasses;
using _19Module.Domain.Responce;
using _The19Module.Services.Interfaces;
using The19Module.DAL.Interfaces;

namespace _The19Module.Services.PerconServices
{
    /// <summary>
    /// Конечный сервис получения клиентов 
    /// </summary>
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository _personRepository)
        {
            personRepository = _personRepository;
        }


        public IBaseResponce<IEnumerable<Person>> GetAllPersons()
        {
            Responce<IEnumerable<Person>> responce = new Responce<IEnumerable<Person>>();
            try
            {
                responce.Data = personRepository.GetAllPersons();
                responce.CodeError = StatusCode.Ok;
            }
            catch (Exception ex)
            {

                responce.CodeError = StatusCode.SomeError;
                responce.Description = $"[GetAllPersons] - {ex.Message}";
            }

            return responce;
        }

        public IBaseResponce<Person> GetPersonById(int id)
        {
            Responce<Person> responce = new Responce<Person>();

            try
            {
                responce.Data = personRepository.GetPersonById(id);
                responce.CodeError = StatusCode.Ok;
            }
            catch (Exception ex)
            {

                responce.CodeError = StatusCode.PersonNotFound;
                responce.Description = $"[GetPersonById] - {ex.Message}";
            }

            return responce;
        }
    }
}
