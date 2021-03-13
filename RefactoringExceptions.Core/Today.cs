using System;

namespace RefactoringExceptions.Core
{    
    public class Today: TodayDate
    {
        virtual public DateTime Date { get { return DateTime.Now.Date; } }
    }
}
