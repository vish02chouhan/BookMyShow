namespace BookMyShow.PricingStrategy
{
    public class MemberDiscountPricingStrategy : IPricingStrategy
    {
        private readonly decimal discountPercentage;

        public MemberDiscountPricingStrategy(decimal discountPercentage)
        {
            this.discountPercentage = discountPercentage;
        }

        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice - (basePrice * discountPercentage / 100);
        }
    }

}
