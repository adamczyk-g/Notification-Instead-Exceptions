using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringExceptions.Core
{
    public class Notification
    {
        private List<string> errors = new List<string>();
        public void AddError(string message) => errors.Add(message);
        public bool HasErrors() => errors.Count != 0;
    }
}
