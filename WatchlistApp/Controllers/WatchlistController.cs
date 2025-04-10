using Microsoft.AspNetCore.Mvc;
using WatchlistApp.Services;
using WatchlistApp.ViewModels;

namespace WatchlistApp.Controllers
{
    public class WatchlistController : Controller
    {
        private readonly IWatchlistService _service;

        public WatchlistController(IWatchlistService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var items = _service.GetAll();
            return View(items);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(WatchlistItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                _service.AddItem(model);
                TempData["Message"] = "Добавлено в список";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Remove(string title)
        {
            _service.RemoveItem(title);
            return RedirectToAction("Index");
        }
    }
}
