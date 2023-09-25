using Curso_Tomi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curso_Tomi.Controllers
{
    
    public class UsersController : Controller
    {
        // GET: UserController
        public ActionResult GetList()
        {
            var user = new UserViewModel()
            {
                Name = "Joel",
                LastName = "Chiaraviglio",
            };


            return View("Index", user);
        }

    }
}
