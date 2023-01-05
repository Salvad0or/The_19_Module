using _19Module.Domain.PersonClasses;

namespace The19Module.DAL.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPersons();

        Person GetPersonById(int id);
    }
}
