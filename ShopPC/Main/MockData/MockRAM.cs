using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockRAM : IRAM
    {

        private readonly ICategoryRAM _categories = new MockCategoryRAM();

        public IEnumerable<RAM> RAMs
        {
            get
            {
                return new List<RAM>
                {
                    new RAM
                    {
                        Name="DDR4 RAM 32GB Apacer 3000MHz",
                        Description="Best RAM for games",
                        Img="/img/DDR4 RAM 32GB Apacer 3000MHz.jpg",
                        Price=4559,
                        Category=_categories.Categories.First()
                    },
                       new RAM
                    {
                        Name="DDR4 RAM 4GB GOODRAM",
                        Description="Good RAM for offices",
                        Img="/img/DDR4 RAM 4GB GOODRAM.jpg",
                        Price=619,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   },
                           new RAM
                    {
                        Name="DDR4 RAM 16GB Apacer 2400MHz",
                        Description="Best RAM for games",
                        Img="/img/DDR4 RAM 16GB Apacer 2400MHz.jpg",
                        Price=2800,
                        Category=_categories.Categories.First()
                    },
                       new RAM
                    {
                        Name="DDR4 RAM 4GB Apacer 2666MHz",
                        Description="Good RAM for offices",
                        Img="/img/DDR4 RAM 4GB Apacer 2666MHz.jpg",
                        Price=569,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   }
                };
            }
        }
    }
}