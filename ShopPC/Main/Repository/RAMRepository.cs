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
    public class RAMRepository : IRAM
    {
        private readonly DBContent dbContent;
        public RAMRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }




        public IEnumerable<RAM> RAMs => dbContent.RAM.Include(c => c.Category);
    }
}