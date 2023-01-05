using _19Module.Domain.Interfaces;
using _19Module.Domain.PersonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _The19Module.Services.Interfaces
{
    /// <summary>
    /// Прокладка между слоем DAL и представлением
    /// </summary>
    public interface IPersonService
    {
        IBaseResponce<IEnumerable<Person>> GetAllPersons();
        IBaseResponce<Person> GetPersonById(int id);
    }
}
