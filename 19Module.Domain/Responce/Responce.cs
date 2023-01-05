using _19Module.Domain.Enums;
using _19Module.Domain.Interfaces;

namespace _19Module.Domain.Responce
{
    /// <summary>
    /// Наш класс ответа от сервисов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Responce<T> : IBaseResponce<T>
    {
        public T Data { get; set; }
        public string Description { get; set; }
        public StatusCode CodeError { get; set; }
    }
}
