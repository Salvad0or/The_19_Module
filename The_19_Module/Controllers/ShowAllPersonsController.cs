using _The19Module.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using The_19_Module.Models;

namespace The_19_Module.Controllers
{
    public class ShowAllPersonsController : Controller
    {
        private readonly IPersonService _personService;
        public ShowAllPersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _personService.GetAllPersons();

            if (result.CodeError == _19Module.Domain.Enums.StatusCode.SomeError)
            {
                return RedirectToAction("Error");
            }

            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
