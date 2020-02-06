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
    public class CPURepository : ICPU
    {
        private readonly DBContent dbContent;
        public CPURepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }


        public IEnumerable<CPU> CPUs => dbContent.CPU.Include(c => c.Category);
    }
}