using Shop.Main.Interfaces;
using Shop.Main.MockData;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.Repository
{
    public class CategoryGPURepository : ICategoryGPU
    {
        private readonly DBContent dbContent;
        public CategoryGPURepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<CategoryGPU> Categories => dbContent.CategoryGPU;

    }
}
