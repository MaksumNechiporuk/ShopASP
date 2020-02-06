using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Main.Interfaces;
using Shop.Main.Models;

namespace Shop.Main.MockData
{
    public class MockCategoryMB : ICategoryMB
    {
        public IEnumerable<CategoryMB> Categories
        {
            get
            {
                return new List<CategoryMB>
                {
                    new CategoryMB{ Name="Game",Description="MB for game"},
                    new CategoryMB{ Name="Simple",Description="MB with low price and without extra functions"}

                };
            }
        }
    }
}
