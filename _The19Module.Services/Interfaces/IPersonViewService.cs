using _19Module.Domain.Interfaces;
using _19Module.Domain.ViewModels;

namespace _The19Module.Services.Interfaces
{
    /// <summary>
    /// Сервис только для класса PersonView
    /// </summary>
    public interface IPersonViewService
    {
        IBaseResponce<PersonViewModel> GetViewPersonById(int id);
    }
}
