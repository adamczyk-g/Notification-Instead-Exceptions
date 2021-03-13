using System;
using RefactoringExceptions.WinForms.View;
using RefactoringExceptions.Core;

namespace RefactoringExceptions.WinForms.Presenter
{
    public class MainPresenter
    {
        private readonly MainView mainView;
        private readonly BookingRequestFactory bookingFactory;
        private readonly TodayDate todayDate;

        public MainPresenter(MainView mainView, BookingRequestFactory bookingFactory, TodayDate todayDate)
        {
            this.mainView = mainView;
            this.bookingFactory = bookingFactory;
            this.todayDate = todayDate;
            mainView.BookSeats += OnBookSeats;            
        }

        private void OnBookSeats(object sender, EventArgs e)
        {
            mainView.ClearMessages();

            BookingRequest bookingRequest = bookingFactory.CreateBookingRequest(mainView.NumberOfSeats, mainView.DateOfThePerformance);

            try
            {
                bookingRequest.Check(todayDate);
            }
            catch(Exception exception)
            {
                mainView.ShowMessage(exception.Message);
            }
        }
    }
}
