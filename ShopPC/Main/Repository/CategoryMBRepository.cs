using Shop.Main.Interfaces;
using Shop.Main.MockData;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.Repository
{
    public class CategoryMBRepository : ICategoryMB
    {
        private readonly DBContent dbContent;
        public CategoryMBRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        IEnumerable<CategoryMB> ICategoryMB.Categories => dbContent.CategoryMB;
    }
}
