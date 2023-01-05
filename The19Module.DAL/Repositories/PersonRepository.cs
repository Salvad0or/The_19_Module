using _19Module.Domain.PersonClasses;
using Microsoft.EntityFrameworkCore;
using The19Module.DAL.Interfaces;

namespace The19Module.DAL.Repositories
{

    /// <summary>
    /// Реализация получения персон
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
        private readonly The19ModuleContext _dbContext;


        public PersonRepository(The19ModuleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();

            
            persons = _dbContext.People.ToList();
            _dbContext.Dispose();


            return persons;
        }

        public Person GetPersonById(int id)
        {
            Person person = new Person();

            using (The19ModuleContext _dbContext = new The19ModuleContext())
            {
                person = _dbContext.People.Single(i => i.Id == id);
            }

            return person;

        }

       
    }
}
