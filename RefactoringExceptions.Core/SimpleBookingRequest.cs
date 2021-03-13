using System;

namespace RefactoringExceptions.Core
{
    public class SimpleBookingRequest: BookingRequest
    {
        private string numberOfSeats;
        private string dateOfThePerformance;
        public SimpleBookingRequest(string numberOfSeats, String bookingDate)
        {
            this.numberOfSeats = numberOfSeats;
            this.dateOfThePerformance = bookingDate;
        }

        public void Check(TodayDate today)
        {
            if (dateOfThePerformance == null) throw new ArgumentNullException("date is missing");

            DateTime parsedDate;            

            try
            {
                parsedDate = DateTime.Parse(dateOfThePerformance);
            }
            catch (System.FormatException e)
            {
                throw new ArgumentOutOfRangeException("Invalid format for date", e);
            }

            if (parsedDate.IsBefore(today.Date)) throw new ArgumentOutOfRangeException("date cannot be before today");


            int parsedNumberOfSeats;

            if (numberOfSeats == string.Empty) throw new ArgumentOutOfRangeException("number of seats cannot be empty");
            
            try
            {
                parsedNumberOfSeats = Convert.ToInt32(numberOfSeats);
            }
            catch (System.FormatException e)
            {
                throw new ArgumentOutOfRangeException("Invalid format for number of seats", e);
            }                     
            
            if (parsedNumberOfSeats < 1) throw new ArgumentOutOfRangeException("number of seats must be positive");
        }    
    }
}
    