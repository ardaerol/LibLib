using System.Web.Mvc;
using LibaryProject.Models.Entity;
namespace LibaryProject.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{
		// GET: Register
#pragma warning disable IDE0044 // Add readonly modifier
		DbLibaryEntities db = new DbLibaryEntities();
#pragma warning restore IDE0044 // Add readonly modifier
		[HttpGet]
		public ActionResult KayitOl()
		{
			return View();
		}
		[HttpPost]
		public ActionResult KayitOl(TblUyeler p)
		{
			db.TblUyeler.Add(p);
			db.SaveChanges();
			return RedirectToAction("KayitOl");
		}
	}
}