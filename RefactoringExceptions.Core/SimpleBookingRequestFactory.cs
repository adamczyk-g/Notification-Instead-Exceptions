using System;

namespace RefactoringExceptions.Core
{
    public class SimpleBookingRequestFactory: BookingRequestFactory
    {
        public SimpleBookingRequestFactory() { }

        public BookingRequest CreateBookingRequest(string numberOfSeats, String bookingDate)
        {
            return new SimpleBookingRequest(numberOfSeats, bookingDate);
        }
    }
}
