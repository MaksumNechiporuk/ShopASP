using Shop.Main.Interfaces;
using Shop.Main.MockData;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.Repository
{
    public class CategoryRAMRepository : ICategoryRAM
    {
        private readonly DBContent dbContent;
        public CategoryRAMRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        IEnumerable<CategoryRAM> ICategoryRAM.Categories => dbContent.CategoryRAM;
    }
}