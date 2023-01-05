using _19Module.Domain.Enums;

namespace _19Module.Domain.Interfaces
{
    public interface IBaseResponce<T>
    {
        T Data { get; set; }
        string Description { get; set; }
        StatusCode CodeError { get; set; }

    }
}
