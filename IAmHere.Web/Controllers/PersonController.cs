using IAmHere.Web.Models.Person;
using IAmHere.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace IAmHere.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: Person
        public ActionResult SearchPersons()
        {
            var personList = _personService.GetPersons();
            return View(personList);
        }
        public IActionResult AddPerson()
        {
            return View();
        }
    }
}
