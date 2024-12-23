# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a class property or field before it's been explicitly assigned a value.  In many languages, this would result in a compiler error. However, in C#, uninitialized class members will have default values (0 for integers, null for reference types, etc.), leading to potentially difficult-to-debug issues. 

The `bug.cs` file shows an example of this issue. The `bugSolution.cs` file provides a solution demonstrating how to correctly initialize the property.

## How to Reproduce
1. Clone this repository.
2. Compile and run `bug.cs`. Observe the output.  (It might be 0).
3. Run `bugSolution.cs`. Observe the difference in behavior.

## Related Issues
This is also relevant to fields within the class, not just properties.