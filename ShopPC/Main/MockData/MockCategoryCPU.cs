using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockCategoryCPU : ICategoryCPU
    {
        public IEnumerable<CategoryCPU> Categories
        {
            get
            {
                return new List<CategoryCPU>
                {
                    new CategoryCPU{ Name="Game",Description="CPU for game"},
                    new CategoryCPU{ Name="Simple",Description="CPU with low price and without extra functions"},
                    new CategoryCPU{ Name="Develop",Description="CPU for develop"},

                };
            }
        }
    }
}
