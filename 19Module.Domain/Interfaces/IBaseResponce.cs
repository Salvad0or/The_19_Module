using _19Module.Domain.Enums;

namespace _19Module.Domain.Interfaces
{
    /// <summary>
    /// Базовый интерфейс для релазации ответа от сервисов
    /// </summary>
    /// <typeparam name="T">Данные которые вернет сервер</typeparam>
    public interface IBaseResponce<T>
    {
        T Data { get; set; }
        string Description { get; set; }
        StatusCode CodeError { get; set; }

    }
}
