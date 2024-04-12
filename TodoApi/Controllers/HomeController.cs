using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{

    public class HomeController : Controller
    {
        private ComplaintContext _context;
        public HomeController(ComplaintContext temp)
        {
            _context = temp;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ComplaintApplication()
        {
            return View("ComplaintApplication");
        }

        [HttpPost]
        public IActionResult ComplaintApplication(Application response)
        {
            response.EntryDate = DateTime.Now;
            response.Solved = false;

            _context.Applications.Add(response);
            _context.SaveChanges();


            return View("Confirmation", response);
        }


        public IActionResult ComplaintData()
        {
            //Linq
            var applications = _context.Applications
                .OrderByDescending(x => x.Deadline).ToList();

            return View(applications);
        }

        [HttpPost]
        public IActionResult MarkAsDone(int id)
        {
            var complaint = _context.Applications.FirstOrDefault(a => a.ApplicationID == id);
            if (complaint != null)
            {
                _context.Applications.Remove(complaint);
                _context.SaveChanges();
            }
            return RedirectToAction("ComplaintData");
        }
    }
}
