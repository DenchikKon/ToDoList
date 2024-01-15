using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
	public class TasksController : Controller
	{
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Add(Tasks task)
		{
			using(Context _context = new())
			{
				task.dateCreate = DateTime.Parse(task.dateCreate.ToShortDateString());
				_context.Add(task);
				_context.SaveChanges();
			}
			return Redirect($"/Home/Index");
		}
		[HttpPost]
		public IActionResult Delete(int id)
		{
			using(Context _context = new())
			{
				_context.Remove(_context.Tasks.Where(m => m.Id == id).FirstOrDefault());
				_context.SaveChanges();
			}
			return Redirect($"/Home/Index");
		}
		[HttpPost]
		public IActionResult CompletedTask(int id) 
		{
			using(Context _context = new())
			{
				_context.Tasks.Where(m => m.Id == id).FirstOrDefault().IsCompleted = !_context.Tasks.Where(m => m.Id == id).FirstOrDefault().IsCompleted;
				_context.SaveChanges();
			}
			return Redirect($"/Home/Index");
		}
	}
}
