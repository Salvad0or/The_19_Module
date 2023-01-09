using _19Module.Domain.Interfaces;
using _19Module.Domain.ViewModels;
using _The19Module.Services.Interfaces;
using _The19Module.Services.PerconServices;
using Microsoft.AspNetCore.Mvc;

namespace The_19_Module.Controllers
{
    public class PersonController : Controller
    {

        private readonly IPersonService _personService;
        public PersonController( IPersonService personService)
        {
            
            _personService = personService;
        }

       
        public IActionResult Index()
        {
            return View();
        }


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
    }
}
