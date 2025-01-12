# C# NullReferenceException on Value Type Property

This repository demonstrates a subtle bug in C# that can lead to a `NullReferenceException` even when dealing with value types.  Value types (like `int`, `float`, `struct`) are typically not nullable, but this example shows a scenario where this assumption can fail.

**The Bug:**
The `MyProperty` is a value type (`int`).  While it won't be null in the traditional sense, the default value for an uninitialized value type property in C# isn't always obvious.  Attempting to call a method on an uninitialized value type can still result in an exception.

**The Solution:**
The solution involves initializing the `MyProperty` either in the constructor or directly before accessing it. This ensures the property has a valid value before it's used.
