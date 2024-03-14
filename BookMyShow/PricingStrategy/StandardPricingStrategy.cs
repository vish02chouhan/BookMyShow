using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.PricingStrategy
{

    public class StandardPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            // Standard pricing with no modifications
            return basePrice;
        }
    }

}
