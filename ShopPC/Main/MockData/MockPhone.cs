using Shop.Main.Interfaces;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class MockPhone : IPhone
    {
        private readonly ICategoryPhone _categoryPhone = new MockCategoryPhone();

        public IEnumerable<Phone> Phones
        {
            get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        Name="Samsung S10",
                        Description="Best phone by Samsung",
                        Img="/img/samsung_galaxy_s10_6_128_gb.jpg",
                        Price=23000,
                        Category=_categoryPhone.Categories.First()
                    },
                       new Phone
                    {
                        Name="Nokia 3310",
                        Description="Old phone",
                        Img="/img/Nokia_3310.jpg",
                        Price=700,
                        Category=_categoryPhone.Categories.Last()
                   }
                };
            }
        }
    }
}
