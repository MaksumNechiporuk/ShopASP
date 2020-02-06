using Microsoft.AspNetCore.Mvc;
using Shop.Main.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class RAMController : Controller
    {
        private readonly IRAM product;
        private readonly ICategoryRAM _categories;


        public RAMController(IRAM Iproduct, ICategoryRAM Icategories)
        {
            product = Iproduct;
            _categories = Icategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Shop";
            RAMListViewModel ListVM = new RAMListViewModel();
            ListVM.Products = product.RAMs;
            ListVM.currentCategory = "Best category";
            return View(ListVM);
        }
    }
}
