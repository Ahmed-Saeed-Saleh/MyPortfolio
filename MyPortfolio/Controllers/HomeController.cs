using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.ViewModels;
using System.Linq;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _portfolioItems;

        public HomeController(IUnitOfWork<Owner> owner, IUnitOfWork<PortfolioItem> PortfolioItems)
        {
            _owner = owner;
            _portfolioItems = PortfolioItems;
        }
        public IActionResult Index()
        {
            var homeviewmodel = new HomeViewModel
            {
                owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _portfolioItems.Entity.GetAll().ToList()

            };
            return View(homeviewmodel);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
