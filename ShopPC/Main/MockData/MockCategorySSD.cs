using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockCategorySSD : ICategorySSD
    {

        public IEnumerable<CategorySSD> Categories
        {
            get
            {
                return new List<CategorySSD>
                {
                    new CategorySSD{ Name="Game",Description="SSD for game"},
                    new CategorySSD{ Name="Simple",Description="SSD with low price and without extra functions"}

                };
            }
        }
    }
}
