using System;

namespace RefactoringExceptions.Core
{
    public static class DateTimeExtension
    {
        public static bool IsBefore(this DateTime date1, DateTime date2)
        {
            return true?DateTime.Compare(date1, date2)<0:false;
        }
    }
}
