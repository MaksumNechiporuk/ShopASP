using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockSSD : ISSD
    {
        private readonly ICategorySSD _categories = new MockCategorySSD();

        public IEnumerable<SSD> SSDs
        {
            get
            {
                return new List<SSD>
                {
                    new SSD
                    {
                        Name="Corsair CSSD-F1000GBMP600",
                        Description="Best SSD for games",
                        Img="/img/Corsair CSSD-F1000GBMP600.jpg",
                        Price=7453,
                        Category=_categories.Categories.First()
                    },
                       new SSD
                    {
                        Name="Goodram SSD CL100",
                        Description="Good SSD for offices",
                        Img="/img/Goodram SSD CL100.jpg",
                        Price=979,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   },
                           new SSD
                    {
                        Name="A-DATA XPG SX8200 Pro ASX8200PNP-1TT-C",
                        Description="Best SSD for games",
                        Img="/img/A-DATA XPG SX8200 Pro ASX8200PNP-1TT-C.jpg",
                        Price=4011,
                        Category=_categories.Categories.First()
                    },
                       new SSD
                    {
                        Name="Team L3 EVO 240GB",
                        Description="Good SSD for offices",
                        Img="/img/Team L3 EVO 240GB.jpg",
                        Price=949,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   }
                };
            }
        }
    }
}