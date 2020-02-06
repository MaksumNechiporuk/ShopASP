using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockCategoryPhone : ICategoryPhone
    {
        public IEnumerable<CategoryPhone> Categories
        {
            get
            {
                return new List<CategoryPhone>
                {
                    new CategoryPhone{ Name="Flagman",Description="Phone with hight price and extra functions"},
                    new CategoryPhone{ Name="Budget",Description="Phone with low price and without extra functions"}
                };
            }
        }
    }
}
