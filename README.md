# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing uninitialized properties.  Uninitialized properties can lead to unexpected behavior or runtime exceptions, making debugging more difficult.

## The Bug
The `bug.cs` file contains a simple class with a property that is not explicitly initialized.  When `MyMethod` is called, it attempts to access this property before a value has been assigned, which may lead to undefined behavior, or in some cases, an exception.

## The Solution
The `bugSolution.cs` file provides a corrected version of the code.  It demonstrates proper initialization of the property either in the constructor or by assigning a default value.