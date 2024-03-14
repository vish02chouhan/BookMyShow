namespace BookMyShow.PricingStrategy
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(decimal basePrice);
    }

}
