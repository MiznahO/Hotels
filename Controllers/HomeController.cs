using Hotels.Data;
using Hotels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hotels.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly AppDbContext _context; 
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult CreatNewRecord(Hotles hotles)
        {
            _context.hotles.Add(hotles);
            _context.SaveChanges();
            return RedirectToAction("Index");   
        }
        public IActionResult Upddate(Hotles hotel)
        {
            _context.Update(hotel);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var hoteledit = _context.hotles.SingleOrDefault(x => x.Id == id);
            return View(hoteledit);

        }


       public IActionResult Delete(int id)
        {
            var hoteldelete = _context.hotles.SingleOrDefault(x => x.Id == id);
            _context.hotles.Remove(hoteldelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var hotels = _context.hotles.ToList();
            return View(hotels);
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