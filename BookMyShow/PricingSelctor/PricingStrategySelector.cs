using BookMyShow.PricingStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.PricingSelctor
{
    public class PricingStrategySelector
    {
        public IPricingStrategy SelectStrategy(DateTime showDate, bool isMember)
        {
            if (showDate.DayOfWeek == DayOfWeek.Saturday || showDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return new StandardPricingStrategy(); // 20% increase for weekend shows
            }
            else if (isMember)
            {
                return new MemberDiscountPricingStrategy(15); // 15% discount for members on weekdays
            }
            else
            {
                return new StandardPricingStrategy();
            }
        }
    }

}
