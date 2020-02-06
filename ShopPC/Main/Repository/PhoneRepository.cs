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
    public class PhoneRepository : IPhone
    {
        private readonly DBContent dbContent;
        public PhoneRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Phone> Phones => dbContent.Phone.Include(c => c.Category);
    }
}