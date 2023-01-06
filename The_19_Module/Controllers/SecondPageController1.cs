using _19Module.Domain.Interfaces;
using _19Module.Domain.PersonClasses;
using _The19Module.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace The_19_Module.Controllers
{
    public class SecondPageController1 : Controller
    {

        private readonly IPersonService _personService;

        public SecondPageController1(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            IBaseResponce<Person> result = _personService.GetPersonById(id);

            if (result.CodeError == _19Module.Domain.Enums.StatusCode.PersonNotFound)
            {
                return View("Error");
            }

            return View(result);
        }
    }
}
