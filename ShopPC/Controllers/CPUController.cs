using Microsoft.AspNetCore.Mvc;
using Shop.Main.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CPUController : Controller
    {
        private readonly ICPU product;
        private readonly ICategoryCPU _categories;


        public CPUController(ICPU Iproduct, ICategoryCPU Icategories)
        {
            product = Iproduct;
            _categories = Icategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Shop";
            CPUListViewModel ListVM = new CPUListViewModel();
            ListVM.Products = product.CPUs;
            ListVM.currentCategory = "Best category";
            return View(ListVM);
        }
    }
}
