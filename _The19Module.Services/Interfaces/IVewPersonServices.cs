using _19Module.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _The19Module.Services.Interfaces
{
    public interface IVewPersonServices
    {
        PersonViewModel GetById(int id);
    }
}
