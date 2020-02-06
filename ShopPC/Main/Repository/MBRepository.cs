using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Main.MockData;
using Shop.Main.Models;

namespace Shop.Main.Repository
{
    public class MBRepository : IMB
    {
        private readonly DBContent dbContent;
        public MBRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<MB> MBs => dbContent.MB.Include(c => c.Category);
    }
}