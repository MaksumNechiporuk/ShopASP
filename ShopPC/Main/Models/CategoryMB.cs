using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.Models
{
    public class CategoryMB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MB> MBs { get; set; }
    }
}
