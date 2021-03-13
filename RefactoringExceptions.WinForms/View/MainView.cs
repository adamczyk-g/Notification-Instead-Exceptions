using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringExceptions.WinForms.View
{
    public interface MainView
    {
        public string NumberOfSeats { get; }
        public string DateOfThePerformance { get; }
        public void ShowMessage(string message);
        public void ClearMessages();

        public event EventHandler BookSeats;        
    }
}
