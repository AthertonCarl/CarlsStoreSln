using Microsoft.AspNetCore.Mvc;
using System.Linq;
using OutdoorWorld.Models;

namespace OutdoorWorld.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private  IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCAtegory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
