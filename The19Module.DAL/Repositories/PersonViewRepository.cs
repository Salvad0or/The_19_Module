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
    public class PersonViewRepository : IPersonViewRepository
    {
        private readonly The19ModuleContext _dbConnext;
        public PersonViewRepository(The19ModuleContext dbConnext)
        {
            _dbConnext = dbConnext;
        }

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
    }
}
