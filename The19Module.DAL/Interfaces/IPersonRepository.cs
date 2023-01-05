using _19Module.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The19Module.DAL.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPersons();

        Person GetPersonById(int id);
    }
}
