using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockCategoryGPU : ICategoryGPU
    {

        public IEnumerable<CategoryGPU> Categories
        {
            get
            {
                return new List<CategoryGPU>
                {
                    new CategoryGPU{ Name="Game",Description="GPU for game"},
                    new CategoryGPU{ Name="Simple",Description="GPU with low price and without extra functions"},
                    new CategoryGPU{ Name="Develop",Description="GPU for develop"},

                };
            }
        }
    }
}
