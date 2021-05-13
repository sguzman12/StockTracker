using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Models
{
    public class StockDto
    {
        public int Id { get; set; }
        public string AlphaCode { get; set; }
        public string Name { get; set; }
        public  decimal Price { get; set; }
    }
}
