using BookMyShow.Model;
using BookMyShow.PricingStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.BookingService
{
    public class BookingService
    {
        private readonly IPricingStrategy pricingStrategy;

        public BookingService(IPricingStrategy pricingStrategy)
        {
            this.pricingStrategy = pricingStrategy;
        }

        public Ticket BookTicket(User user, Show show, Seat seat, decimal basePrice)
        {
            var finalPrice = pricingStrategy.CalculatePrice(basePrice);

            var ticket = new Ticket
            {
                Show = show,
                Seat = seat,
                Price = finalPrice
            };

            // Assume logic to save the ticket to a database or in-memory store

            return ticket;
        }
    }

}
