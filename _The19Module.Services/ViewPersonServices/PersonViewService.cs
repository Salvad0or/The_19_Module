using _19Module.Domain.Interfaces;
using _19Module.Domain.Responce;
using _19Module.Domain.ViewModels;
using _The19Module.Services.Interfaces;
using The19Module.DAL.Interfaces;

namespace _The19Module.Services.ViewPersonServices
{
    /// <summary>
    /// Сервис для работы и обработки класса PersonView
    /// </summary>
    public class PersonViewService : IPersonViewService
    {
        private readonly IPersonViewRepository _personViewRepository;

        public PersonViewService(IPersonViewRepository personViewRepository)
        {
            _personViewRepository = personViewRepository;
        }

        /// <summary>
        /// Переливаем обычного Person в ViewPerson
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IBaseResponce<PersonViewModel> GetViewPersonById(int id)
        {

            var responce = new Responce<PersonViewModel>();

            try
            {
                responce.Data = _personViewRepository.GetById(id);
                responce.CodeError = _19Module.Domain.Enums.StatusCode.Ok;

            }
            catch (Exception ex)
            {

                responce.CodeError = _19Module.Domain.Enums.StatusCode.PersonNotFound;
                responce.Description = $"[GetViewPersonById] - {ex.Message}";
            }

            return responce;
            
        }
    }
}
