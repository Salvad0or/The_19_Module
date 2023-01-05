namespace _19Module.Domain.Person
{
    public interface IPerson
    {
        public int Id { get; }
        public string Name { get; }
        public string SecondName { get; }
        public string Patronymic { get; }
        public string PhoneNumber { get; }
        public string Adress { get; }
        public string Description { get; }

    }
}
