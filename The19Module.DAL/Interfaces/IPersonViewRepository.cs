using _19Module.Domain.PersonClasses;
using _19Module.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The19Module.DAL.Interfaces
{
    public interface IPersonViewRepository : IBaseRepository<PersonViewModel>
    {
    }
}
