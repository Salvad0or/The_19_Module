using _19Module.Domain.PersonClasses;

namespace The19Module.DAL.Interfaces
{
    /// <summary>
    /// Стандартный интерфейс репозитория для клиента
    /// </summary>
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPersons();

        Person GetPersonById(int id);
    }
}
