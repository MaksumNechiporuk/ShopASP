using Shop.Main.Interfaces;
using Shop.Main.MockData;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.Repository
{
    public class CategoryCPURepository:ICategoryCPU
    {
        private readonly DBContent dbContent;
        public CategoryCPURepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        IEnumerable<CategoryCPU> ICategoryCPU.Categories => dbContent.CategoryCPU;
    }
}
