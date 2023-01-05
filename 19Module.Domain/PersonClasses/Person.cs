using _19Module.Domain.Person;

namespace _19Module.Domain.PersonClasses
{
    /// <summary>
    /// Класс самой персоны
    /// </summary>
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
