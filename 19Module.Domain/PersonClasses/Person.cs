using _19Module.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Module.Domain.PersonClasses
{
    public class Person : IPerson
    {
        public int Id { get; }

        public string? Name { get; }

        public string? SecondName { get; }

        public string? Patronymic { get; }

        public string? PhoneNumber { get; }

        public string? Adress { get; }

        public string? Description { get; }
    }
}
