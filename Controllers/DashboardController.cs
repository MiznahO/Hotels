using Hotels.Data;
using Hotels.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;

		}

		public IActionResult RoomDetails()
		{
			var hotel = _context.hotles.ToList();
			var rooms = _context.rooms.ToList();
			ViewBag.hotles = hotel;
			ViewBag.rooms = rooms;

			var roomDetails = _context.roomDetails.ToList();
			return View(roomDetails);
		}
		public IActionResult CreateNewRoomDetails(RoomDetails roomDetails)
		{
			_context.roomDetails.Add(roomDetails);
			_context.SaveChanges();
			return RedirectToAction("RoomDetails");
		}

		public IActionResult CreateNewRooms(Rooms rooms)
		{
			_context.rooms.Add(rooms);
			_context.SaveChanges();

			return RedirectToAction("Rooms");
		}

		public IActionResult Rooms()
		{
			var hotel = _context.hotles.ToList();
			ViewBag.hotles=hotel;

			var rooms = _context.rooms.ToList();
			return View(rooms);
		}

		[HttpPost]
		public IActionResult Index(string city)
		{
			var hotel = _context.hotles.Where(x => x.City == city);
			return View(hotel);


		}
		public IActionResult Edit(int id)
		{
			var hoteledit = _context.hotles.SingleOrDefault(x => x.Id == id);
			return View(hoteledit);
           

        }

        public IActionResult Update(Hotles hotles)
        {
           
				_context.hotles.Update(hotles);
				_context.SaveChanges();
			    TempData["Up"] = "Okay";
			    return RedirectToAction("Index");
				
			
            
        }
		
		public IActionResult Delete(int id)
		{
			var hoteldelete = _context.hotles.SingleOrDefault(x => x.Id == id);
            if (hoteldelete != null)
            {
				_context.hotles.Remove(hoteldelete);
				_context.SaveChanges();
                TempData["Del"] = "Ok";
			}
			return RedirectToAction("Index");
		}
		[Authorize]
		public IActionResult Index()
        {
            var hotel = _context.hotles.ToList();
            return View(hotel);
        }
        public IActionResult CreateNewHotel(Hotles hotels)
        {
            _context.hotles.Add(hotels);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
