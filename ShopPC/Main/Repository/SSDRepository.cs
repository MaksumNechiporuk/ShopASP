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
    public class SSDRepository : ISSD
    {
        private readonly DBContent dbContent;
        public SSDRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }



        public IEnumerable<SSD> SSDs => dbContent.SSD.Include(c => c.Category);
    }
}