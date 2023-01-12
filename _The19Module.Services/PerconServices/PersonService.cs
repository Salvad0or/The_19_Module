using _19Module.Domain.Enums;
using _19Module.Domain.Interfaces;
using _19Module.Domain.PersonClasses;
using _19Module.Domain.Responce;
using _19Module.Domain.ViewModels;
using _The19Module.Services.Interfaces;
using Azure;
using The19Module.DAL.Interfaces;

namespace _The19Module.Services.PerconServices
{
    /// <summary>
    /// Конечный сервис получения клиентов 
    /// </summary>
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository _personRepository)
        {
            this._personRepository = _personRepository;
        }

        /// <summary>
        /// Получение списка всех клиентов
        /// </summary>
        /// <returns></returns>
        public IBaseResponce<IEnumerable<Person>> GetAllPersons()
        {
            Responce<IEnumerable<Person>> responce = new Responce<IEnumerable<Person>>();
            try
            {
                responce.Data = _personRepository.GetAllPersons();
                responce.CodeError = StatusCode.Ok;
            }
            catch (Exception ex)
            {

                responce.CodeError = StatusCode.SomeError;
                responce.Description = $"[GetAllPersons] - {ex.Message}";
            }

            return responce;
        }

        /// <summary>
        /// Получить клиента по id из общей таблицы
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IBaseResponce<Person> GetPersonById(int id)
        {
            Responce<Person> responce = new Responce<Person>();

            try
            {
                responce.Data = _personRepository.GetById(id);
                responce.CodeError = StatusCode.Ok;
            }
            catch (Exception ex)
            {

                responce.CodeError = StatusCode.PersonNotFound;
                responce.Description = $"[GetPersonById] - {ex.Message}";
            }

            return responce;
        }

        /// <summary>
        /// Добавить нового человека
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public IBaseResponce<bool> AddNewPerson(PersonViewModel viewModel)
        {
            Responce<bool> responce = new Responce<bool>();

            try
            {
                responce.Data = _personRepository.Add(viewModel);
            }
            catch (Exception ex)
            {

                responce.CodeError = StatusCode.ICantAddPerson;
                responce.Description = $"[GetPersonById] - {ex.Message}";
            }

            return responce;
        }

        /// <summary>
        /// Редактировать нового человека
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IBaseResponce<bool> EditPerson(PersonViewModel viewModel)
        {
            IBaseResponce<bool> baseResponce = new Responce<bool>();

            try
            {
                baseResponce.Data = _personRepository.Edit(viewModel);
                baseResponce.Description = $"Редактирование прошло успешно";
            }
            catch (Exception ex)
            {

                baseResponce.CodeError = StatusCode.CantEditPerson;
                baseResponce.Description = $"[EditPerson] - {ex.Message}";
            }

            return baseResponce;
        }

        /// <summary>
        /// Удаление уже имеющейся персоны прямиком из вью
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IBaseResponce<bool> Delete(int id)
        {
            IBaseResponce<bool> responce = new Responce<bool>();

            try
            {
                responce.Data = _personRepository.Delete(id);
                responce.CodeError = StatusCode.Ok;
            }
            catch (Exception ex)
            {
                responce.CodeError = StatusCode.CantDeletePerson;
                responce.Description = $"[Delete] - {ex.Message}";
                
            }

            return responce;
        }
    }
}
