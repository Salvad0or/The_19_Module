using _19Module.Domain.Interfaces;
using _19Module.Domain.PersonClasses;
using _19Module.Domain.Responce;
using _19Module.Domain.ViewModels;
using _The19Module.Services.Interfaces;
using _The19Module.Services.PerconServices;
using _The19Module.Services.ViewPersonServices;
using Microsoft.AspNetCore.Mvc;

namespace The_19_Module.Controllers
{
    public class PersonController : Controller
    {
        #region Private поля и свойства

        private readonly IPersonService _personService;
        private readonly IPersonViewService _personViewService;

        private const string _pathToBadView = "/Views/Person/PatternsViews/BaseError.cshtml";
        private const string _pathTSuccessView = "/Views/Person/PatternsViews/SuccessfullView.cshtml";
        public PersonController( IPersonService personService, IPersonViewService personViewService)
        {
            _personViewService = personViewService;
            _personService = personService;
        }

        #endregion

        #region Вывод таблицы всех клиентов на экран
        [HttpGet]
        public IActionResult ShowAllPersons()
        {
            var result = _personService.GetAllPersons();

            if (result.CodeError == _19Module.Domain.Enums.StatusCode.SomeError)
            {
                return RedirectToAction("_pathToBadView");
            }

            return View(result);
        }

        #endregion

        #region Реализация показа полного досье
        public IActionResult ShowPersonById(int id)
        {
            IBaseResponce<Person> result = _personService.GetPersonById(id);

            if (result.CodeError == _19Module.Domain.Enums.StatusCode.PersonNotFound)
            {
                return View(_pathToBadView, result.Description);
            }

            return View(result);
        }

        #endregion

        #region Реализация добавления нового клиента

        [HttpGet]
        public IActionResult AddNewPerson() => View();

        [HttpPost]
        public IActionResult AddNewPerson(PersonViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                IBaseResponce<bool> responce = _personService.AddNewPerson(viewModel);

                if (responce.Data is true)
                {
                    return View(_pathTSuccessView, $"Клиент {viewModel.Name} был успешно добавлен в базу данных");
                }

            }
            return View();

        }

        #endregion

        #region Реализация редактирования старого клиента

        /// <summary>
        /// Здесь получаем Id и переводим клиента во вью-класс
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditPersonById(int id)
        {
            var personViewMode =  _personViewService.GetViewPersonById(id);

            if (personViewMode.CodeError == _19Module.Domain.Enums.StatusCode.PersonNotFound)
            {
                return View(_pathToBadView, "Клиент не был найден");
            }

            return View("EditPerson", personViewMode.Data);
        }

        /// <summary>
        /// Здесь уже непосредственный запрос к базе данных и изменение клиента
        /// </summary>
        /// <param name="personViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditPerson(PersonViewModel personViewModel)
        {
            if (ModelState.IsValid)
            {
                IBaseResponce<bool> result= _personService.EditPerson(personViewModel);

                if (result.Data is true)
                {
                    return View(_pathTSuccessView);
                }  
            }

            return View(personViewModel);
        }


        #endregion

        #region Реализация удаления имеющегося клиента

        
        public IActionResult DeletePerson(int id)
        {
            IBaseResponce<bool> response = _personService.Delete(id);

            if (response.Data is true)
            {
                string answer = $"Удаление прошло успешно";
                                

                return View(_pathTSuccessView, answer);
            }

            return View(_pathToBadView);
        }

        #endregion
    }
}
