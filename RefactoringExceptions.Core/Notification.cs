using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringExceptions.Core
{
    public class Notification
    {
        private List<Error> errors = new List<Error>();
        public void AddError(string message) => AddError(message, null);
        public void AddError(string message, Exception exception) => errors.Add(new Error(message, exception));
        public bool HasErrors() => errors.Count != 0;
        public string ErrorMessage => string.Join(Environment.NewLine, errors.Select(error => error.Message).ToList());
        private class Error
        {
            public Error(String message, Exception cause)
            {
                Message = message;
                Cause = cause;
            }

            public string Message { get; private set; }
            public Exception Cause { get; private set; }
        }
    }
}
