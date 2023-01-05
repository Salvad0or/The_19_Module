using _19Module.Domain.Interfaces;
using _19Module.Domain.PersonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _The19Module.Services.Interfaces
{
    public interface IPersonService
    {
        IBaseResponce<IEnumerable<Person>> GetAllPersons();
        IBaseResponce<Person> GetPersonById();
    }
}
