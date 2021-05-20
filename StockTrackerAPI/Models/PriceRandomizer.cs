using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Models
{
    public class PriceRandomizer
    {
        decimal MIN_VALUE = -3.0M;
        decimal MAX_VALUE = 3.0M;

        public decimal RandomizePrice(decimal price)
        {
            return price * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
        }
    }
}
