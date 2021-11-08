using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompatibilityChecker.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public string PartSpec { get; set; }
        public decimal PartPrice { get; set; }

        public Part()
        {

        }
    }
    
}
