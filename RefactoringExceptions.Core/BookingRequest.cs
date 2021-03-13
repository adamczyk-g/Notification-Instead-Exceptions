namespace RefactoringExceptions.Core
{
    public interface BookingRequest
    {
        public Notification Validation(TodayDate today);
    }
}
