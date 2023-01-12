using _19Module.Domain.PersonClasses;
using _19Module.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The19Module.DAL.Interfaces;

namespace The19Module.DAL.Repositories
{
    /// <summary>
    /// Репозиторий View Person
    /// </summary>
    public class PersonViewRepository : IPersonViewRepository
    {
        private readonly The19ModuleContext _dbConnext;
        public PersonViewRepository(The19ModuleContext dbConnext)
        {
            _dbConnext = dbConnext;
        }

        /// <summary>
        /// получение по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PersonViewModel GetById(int id)
        {
            PersonViewModel personViewModel = new PersonViewModel();

            try
            {
                var Person = _dbConnext.People.Single(i => i.Id == id);

                personViewModel.Id = Person.Id;
                personViewModel.Name = Person.Name;
                personViewModel.SecondName = Person.SecondName;
                personViewModel.Patronymic = Person.Patronymic;
                personViewModel.PhoneNumber = Person.PhoneNumber;
                personViewModel.Adress = Person.Adress;

                return personViewModel;

            }
            catch (Exception ex)
            {

                return personViewModel;
            }
        }

        /// <summary>
        /// Удаление уже имеющейся вью.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return default;
            // Пока нет реализации;
        }
    }
}
