using Microsoft.AspNetCore.Mvc;
using Shop.Main.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class SSDController : Controller
    {
        private readonly ISSD product;
        private readonly ICategorySSD _categories;

        public SSDController(ISSD Iproduct, ICategorySSD Icategories)
        {
            product = Iproduct;
            _categories = Icategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Shop";
            SSDListViewModel ListVM = new SSDListViewModel();
            ListVM.Products = product.SSDs;
            ListVM.currentCategory = "Best category";
            return View(ListVM);
        }
    }
}
