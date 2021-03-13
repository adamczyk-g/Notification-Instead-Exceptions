using System;

namespace RefactoringExceptions.Core
{
    public interface BookingRequestFactory
    {
        public BookingRequest CreateBookingRequest(string numberOfSeats, String bookingDate);
    }
}
