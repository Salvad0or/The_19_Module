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

        /// <summary>
        /// Получение всех клиентов
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();

            
            persons = _dbContext.People.ToList();
            _dbContext.Dispose();


            return persons;
        }

        /// <summary>
        /// Получение клиента по его Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetById(int id)
        {

            var person = _dbContext.People.Single(i => i.Id == id);

            _dbContext.Dispose();

            return person;

        }

        /// <summary>
        /// Добавление новго клиента
        /// </summary>
        /// <param name="personViewModel"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Редактирование уже имеющегося клиента
        /// </summary>
        /// <param name="personViewModel"></param>
        /// <returns></returns>
        public bool Edit(PersonViewModel personViewModel)
        {
            try
            {
                Person person = _dbContext.People.Single(i => i.Id == personViewModel.Id);


                person.Name = personViewModel.Name;
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

        /// <summary>
        /// Удаление уже имеющегося клиента
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Delete(int Id)
        {
            try
            {
                Person person = _dbContext.People.Single(i => i.Id == Id);

                _dbContext.People.Remove(person);
                _dbContext.SaveChanges();
                _dbContext.Dispose();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
