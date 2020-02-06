using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockCPU : ICPU
    {
        private readonly ICategoryCPU _categories= new MockCategoryCPU();


        public IEnumerable<CPU> CPUs
        {
            get
            {
                return new List<CPU>
                {
                    new CPU
                    {
                        Name="Intel Core i7 9700KF 3.6GHz",
                        Description="Best CPU for games",
                        Img="/img/Intel Core i7 9700KF 3.6GHz.jpg",
                        Price=12900,
                        Category=_categories.Categories.First()
                    },
                       new CPU
                    {
                        Name="Intel Pentium G4560",
                        Description="Good CPU for offices",
                        Img="/img/Intel Pentium G4560.jpg",
                        Price=3700,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   },
                           new CPU
                    {
                        Name="Intel Core i7 9700KF 3.6GHz",
                        Description="Best CPU for games",
                        Img="/img/Intel Core i7 9700KF 3.6GHz.jpg",
                        Price=12900,
                        Category=_categories.Categories.First()
                    },
                       new CPU
                    {
                        Name="Intel Pentium Gold G5400",
                        Description="Good CPU for offices",
                        Img="/img/Intel Pentium Gold G5400.jpg",
                        Price=1600,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   },
                       new CPU
                    {
                        Name="INTEL Core™ i7 9700K",
                        Description="Good CPU for develop",
                        Img="/img/INTEL Core™ i7 9700K.jpg",
                        Price=11800,
                        Category=_categories.Categories.Last()
                   }
                };
            }
        }
    }
}