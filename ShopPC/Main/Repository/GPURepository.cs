using Microsoft.EntityFrameworkCore;
using Shop.Main.Interfaces;
using Shop.Main.MockData;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.Repository
{
    public class GPURepository : IGPU
    {
        private readonly DBContent dbContent;
        public GPURepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<GPU> GPUs => dbContent.GPU.Include(c => c.Category);
    }
}