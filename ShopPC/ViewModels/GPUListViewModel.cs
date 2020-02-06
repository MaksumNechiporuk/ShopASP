using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class GPUListViewModel
    {
        public IEnumerable<GPU> Products { get; set; }
        public string currentCategory { get; set; }
    }
}
