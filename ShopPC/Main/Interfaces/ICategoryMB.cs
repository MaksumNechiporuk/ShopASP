using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.Interfaces
{
  public   interface ICategoryMB
    {
        IEnumerable<CategoryMB> Categories { get; }

    }
}
