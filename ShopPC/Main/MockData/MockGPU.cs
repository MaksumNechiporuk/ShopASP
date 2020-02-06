using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockGPU : IGPU
    {
        private readonly ICategoryGPU _categories = new MockCategoryGPU();

        public IEnumerable<GPU> GPUs
        {
            get
            {
                return new List<GPU>
                {
                    new GPU
                    {
                        Name="Asus PCI-Ex GeForce RTX 2080 Ti",
                        Description="Best GPU for games",
                        Img="/img/Asus PCI-Ex GeForce RTX 2080 Ti.jpg",
                        Price=36823,
                        Category=_categories.Categories.First()
                    },
                       new GPU
                    {
                        Name="Asus PCI-Ex GeForce GT 710 1GB",
                        Description="Good GPU for offices",
                        Img="/img/Asus PCI-Ex GeForce GT 710 1GB.jpg",
                        Price=1006,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   },
                           new GPU
                    {
                        Name="Asus PCI-Ex GeForce RTX 2080 Super",
                        Description="Best GPU for games",
                        Img="/img/Asus PCI-Ex GeForce RTX 2080 Super.jpg",
                        Price=22931,
                        Category=_categories.Categories.First()
                    },
                     
                       new GPU
                    {
                        Name="PNY PCI-Ex NVIDIA Quadro RTX6000 24GB",
                        Description="Good GPU for develop",
                        Img="/img/PNY PCI-Ex NVIDIA Quadro RTX6000 24GB.jpg",
                        Price=123930,
                        Category=_categories.Categories.Last()
                   }
                };
            }
        }
    }
}