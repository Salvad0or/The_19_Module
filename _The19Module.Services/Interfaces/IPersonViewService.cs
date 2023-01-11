using _19Module.Domain.Interfaces;
using _19Module.Domain.ViewModels;

namespace _The19Module.Services.Interfaces
{
    public interface IPersonViewService
    {
        IBaseResponce<PersonViewModel> GetViewPersonById(int id);
    }
}
