using _19Module.Domain.Person;
using The19Module.DAL.Interfaces;

namespace The19Module.DAL.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();

            using (The19ModuleContext dbContext = new The19ModuleContext())
            {
                persons = dbContext.People.ToList();
            }

            return persons;
        }

        public Person GetPersonById(int id)
        {
            Person person = new Person();

            using (The19ModuleContext dbContext = new The19ModuleContext())
            {
                person = dbContext.People.Single(i => i.Id == id);
            }

            return person;

        }
    }
}
