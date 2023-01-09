using _19Module.Domain.Person;
using System.ComponentModel.DataAnnotations;

namespace _19Module.Domain.PersonClasses
{
    /// <summary>
    /// Класс самой персоны
    /// </summary>
    public class Person : IPerson
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? SecondName { get; set; }

        public string? Patronymic { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Adress { get; set; }

        public string? Description { get; set; }
    }
}
