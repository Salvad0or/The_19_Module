using _19Module.Domain.PersonClasses;
using _19Module.Domain.ViewModels;

namespace The19Module.DAL.Interfaces
{
    /// <summary>
    /// Стандартный интерфейс репозитория для клиента
    /// </summary>
    public interface IPersonRepository :IBaseRepository<Person>
    {
        IEnumerable<Person> GetAllPersons();

        Person GetById(int id);

        bool Add(PersonViewModel personViewModel);

        bool Edit(PersonViewModel personViewModel);


    }
}
