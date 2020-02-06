using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Main.Interfaces;
using Shop.Main.Models;

namespace Shop.Main.MockData
{
    public class MockMB : IMB
    {
        private readonly ICategoryMB _categories = new MockCategoryMB();

        public IEnumerable<MB> MBs
        {
            get
            {
                return new List<MB>
                {
                    new MB
                    {
                        Name="MSI X299 GAMING PRO CARBON",
                        Description="Best MB for games",
                        Img="/img/MSI X299 GAMING PRO CARBON.jpg",
                        Price=37499,
                        Category=_categories.Categories.First()
                    },
                       new MB
                    {
                        Name="ASRock FM2A68M-DG3+",
                        Description="Good MB for offices",
                        Img="/img/ASRock FM2A68M-DG3+.jpg",
                        Price=1023,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   },
                           new MB
                    {
                        Name="MSI MEG X570 GODLIKE",
                        Description="Best MB for games",
                        Img="/img/MSI MEG X570 GODLIKE.jpg",
                        Price=23426,
                        Category=_categories.Categories.First()
                    },
                       new MB
                    {
                        Name="Asus Prime A320M-K",
                        Description="Good MB for offices",
                        Img="/img/Asus Prime A320M-K.jpg",
                        Price=1310,
                        Category=_categories.Categories.SingleOrDefault(el=>el.Name=="Simple")
                   },
                       new MB
                    {
                        Name="ASRock X570 AQUA",
                        Description="Good MB for develop",
                        Img="/img/ASRock X570 AQUA.png",
                        Price=123930,
                        Category=_categories.Categories.Last()
                   }
                };
            }
        }
    }
}