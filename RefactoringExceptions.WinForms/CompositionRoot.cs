using RefactoringExceptions.Core;
using RefactoringExceptions.WinForms.Presenter;
using RefactoringExceptions.WinForms.View;

namespace RefactoringExceptions.WinForms
{
    public class CompositionRoot
    {
        public CompositionRoot() {

            BookingRequestFactory bookingFactory = new SimpleBookingRequestFactory();
            MainView = new MainForm();
            TodayDate todayDate = new Today();

            MainPresenter mainPresenter = new MainPresenter(MainView, bookingFactory, todayDate);        
        }

        //needed for Application.Run
        public MainView MainView { get; private set; }

    }
}
