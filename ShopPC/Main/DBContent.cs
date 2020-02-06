using Microsoft.EntityFrameworkCore;
using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {

        }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<CategoryPhone> CategoryPhone { get; set; }
        public DbSet<CPU> CPU { get; set; }
        public DbSet<CategoryCPU> CategoryCPU { get; set; }
        public DbSet<GPU> GPU { get; set; }
        public DbSet<CategoryGPU> CategoryGPU { get; set; }
        public DbSet<MB> MB { get; set; }
        public DbSet<CategoryMB> CategoryMB{ get; set; }
        public DbSet<RAM> RAM { get; set; }
        public DbSet<CategoryRAM> CategoryRAM { get; set; }
        public DbSet<SSD> SSD { get; set; }
        public DbSet<CategorySSD> CategorySSD { get; set; }
    }
}
