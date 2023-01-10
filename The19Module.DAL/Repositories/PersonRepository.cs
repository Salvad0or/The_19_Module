using _19Module.Domain.PersonClasses;
using _19Module.Domain.ViewModels;
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

        public Person GetById(int id)
        {

            var person = _dbContext.People.Single(i => i.Id == id);

            _dbContext.Dispose();

            return person;

        }

        public bool Add(PersonViewModel personViewModel)
        {
            Person person = new Person()
            {
                Name = personViewModel.Name,
                SecondName = personViewModel.SecondName,
                Patronymic = personViewModel.Patronymic,
                Adress = personViewModel.Adress,
                PhoneNumber = personViewModel.PhoneNumber,
            };

            try
            {
                _dbContext.Add(person);
                _dbContext.SaveChanges();
                _dbContext.Dispose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Edit(PersonViewModel personViewModel)
        {
            try
            {

                Person person = _dbContext.People.Single(i => i.Id == personViewModel.Id);

                person.Adress = personViewModel.Adress;
                person.Patronymic = personViewModel.Patronymic;
                person.PhoneNumber = personViewModel.PhoneNumber;
                person.SecondName = personViewModel.SecondName;
                person.Adress = personViewModel.Adress;

                _dbContext.SaveChanges();
                _dbContext.Dispose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
