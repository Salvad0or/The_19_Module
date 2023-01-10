using _19Module.Domain.PersonClasses;
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

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
