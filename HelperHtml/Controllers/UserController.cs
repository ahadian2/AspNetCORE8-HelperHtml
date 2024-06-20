using HelperHtml.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelperHtml.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Mohammadreza",
                Family = "Ahadian",
                Description = "Description ...",
                Gender = true,
            };
            return View(person);
        }
    }
}
