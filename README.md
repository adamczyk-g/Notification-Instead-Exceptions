# Using the Notification pattern instead of exceptions
## Refactoring Example

The project shows the refactoring steps from an exception-based validation mechanism to a validation mechanism using the Notification pattern.

The code is an illustration for Martin Fowler's article: ["Replacing Throwing Exceptions with Notification in Validations"](https://martinfowler.com/articles/replaceThrowWithNotification.html). The example is translated from Java to C# and expanded into a working project, complete with tests and a simple user interface.

Exceptions are a good way to handle unexpected events. They allow you to remove their handling from the mainstream logic, i.e. from the normal flow of the program. 

However, exceptions should not be used in situations where the occurrence of errors is easy to predict and rather frequent, so not exceptional at all.

An example is data validation. If we check the data entered by the user, we expect errors in them, and therefore their verification belongs to the main logic of the application.

Whether it is better to use exceptions or the notification pattern in a given situation depends on the context. For example, errors during file operations can be both unexpected (some system file is missing) and quite normal and expected (the path to the file was given by the user)
