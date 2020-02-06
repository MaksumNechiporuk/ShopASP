using Microsoft.AspNetCore.Mvc;
using Shop.Main.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class GPUController : Controller
    {
        private readonly IGPU product;
        private readonly ICategoryGPU _categories;


        public GPUController(IGPU Iproduct, ICategoryGPU Icategories)
        {
            product = Iproduct;
            _categories = Icategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Shop";
            GPUListViewModel ListVM = new GPUListViewModel();
            ListVM.Products = product.GPUs;
            ListVM.currentCategory = "Best category";
            return View(ListVM);
        }
    }
}
