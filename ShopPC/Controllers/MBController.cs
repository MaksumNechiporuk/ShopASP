using Microsoft.AspNetCore.Mvc;
using Shop.Main;
using Shop.Main.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class MBController : Controller
    {
        private readonly IMB product;
        private readonly ICategoryMB _categories;


        public MBController(IMB Iproduct, ICategoryMB Icategories)
        {
            product = Iproduct;
            _categories = Icategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Shop";
            MBListViewModel ListVM = new MBListViewModel();
            ListVM.Products = product.MBs;
            ListVM.currentCategory = "Best category";
            return View(ListVM);
        }
    }
}
