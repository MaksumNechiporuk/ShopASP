using Shop.Main.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IPhone _phones;
        private readonly ICategoryPhone _categories;

    
        public PhoneController(IPhone Iphones,ICategoryPhone Icategories)
        {
            _phones = Iphones;
            _categories= Icategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Shop";
            PhoneListViewModel phoneListVM = new PhoneListViewModel();
            phoneListVM.Phones = _phones.Phones;
            phoneListVM.currentCategory = "Best category";
            return View(phoneListVM);
        }
    }
}
