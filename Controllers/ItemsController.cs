using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;

namespace Shop.Controllers
{
    public class ItemsController : Controller
    {
        private IItems _allItems;
        private ICategories _allCategories;

        public ItemsController(IItems allItems, ICategories allCategories)
        {
            _allItems = allItems;
            _allCategories = allCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с предметами";
            var items = _allItems.AllItems;
            return View(items);
        }
    }
}