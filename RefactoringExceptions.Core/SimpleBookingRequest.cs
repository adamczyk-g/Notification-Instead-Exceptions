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
            if (Validation(today).HasErrors())
                throw new ArgumentOutOfRangeException(Validation(today).ErrorMessage);
        }

        public Notification Validation(TodayDate today)
        {
            Notification note = new Notification();

            ValidateDate(today, note);

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

            return note;
        }

        private void ValidateDate(TodayDate today, Notification note)
        {
            if (dateOfThePerformance == null) 
            { 
                note.AddError("date is missing"); 
                return; 
            }

            DateTime parsedDate;

            try
            {
                parsedDate = DateTime.Parse(dateOfThePerformance);
            }
            catch (System.FormatException e)
            {
                note.AddError("Invalid format for date", e);
                return;
            }

            if (parsedDate.IsBefore(today.Date)) note.AddError("date cannot be before today");
        }
    }
}
    