using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockCategoryRAM : ICategoryRAM
    {
        public IEnumerable<CategoryRAM> Categories
        {
            get
            {
                return new List<CategoryRAM>
                {
                    new CategoryRAM{ Name="Game",Description="RAM for game"},
                    new CategoryRAM{ Name="Simple",Description="RAM with low price and without extra functions"},
                    new CategoryRAM{ Name="Develop",Description="RAM for develop"},

                };
            }
        }
    }
}
