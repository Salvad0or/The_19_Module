using _19Module.Domain.Interfaces;


namespace The19Module.Services.Interfaces
{
    public interface IPersonService
    {
        IBaseResponce<IEnumerable<Person>> GetAllPersons();
        IBaseResponce<Person> GetPersonById();
    }
}
