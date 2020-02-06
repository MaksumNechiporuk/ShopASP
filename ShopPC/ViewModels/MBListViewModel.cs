using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class MBListViewModel
    {
        public IEnumerable<MB> Products { get; set; }
        public string currentCategory { get; set; }
    }
}
