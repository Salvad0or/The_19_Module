using _19Module.Domain.Interfaces;
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

        private readonly IPersonService _personService;
        private readonly IPersonViewService _personViewService;
        public PersonController( IPersonService personService, IPersonViewService personViewService)
        {
            _personViewService = personViewService;
            _personService = personService;
        }

       
        public IActionResult Index()
        {
            return View();
        }


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
                    return View("ICouldAddNewPerson", viewModel.Name);
                }

            }
            return View();

        }

        #endregion

        #region Реализация редактирования старого клиента

        [HttpGet]
        public IActionResult GetPersonById(int id)
        {
            var personViewMode =  _personViewService.GetViewPersonById(id);

            if (personViewMode.CodeError == _19Module.Domain.Enums.StatusCode.PersonNotFound)
            {
                return View("PersonDidntFound");
            }

            return View("EditPerson", personViewMode.Data);
        }

        [HttpPost]
        public IActionResult EditPerson(PersonViewModel personViewModel)
        {
            if (ModelState.IsValid)
            {
                IBaseResponce<bool> result= _personService.EditPerson(personViewModel);

                if (result.Data is true)
                {
                    return View("ICouldEditPerson");
                }  
            }

            return View(personViewModel);
        }


        #endregion

        #region Реализация удаления имеющегося клиента

        [HttpPost]
        public IActionResult DeletePerson(int id)
        {
            IBaseResponce<bool> response = _personService.Delete(id);

            if (response.Data is true)
            {
                string answer = $"Удаление прошло успешно";
                                

                return View("SuccessfullView", answer);
            }

            return View("BaseError", response.Data);
        }

        #endregion
    }
}
