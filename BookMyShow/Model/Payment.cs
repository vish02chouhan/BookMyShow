﻿namespace BookMyShow.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } // Consider using an enum for status
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
    }


}
