using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (Context context = new Context())
            {
                List<Tasks> tasks = context.Tasks.ToList();
				return View(tasks);
			}
                
        }

    }
}