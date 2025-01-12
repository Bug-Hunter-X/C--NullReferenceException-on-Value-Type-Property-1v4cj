public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // Initialize MyProperty in the constructor
        MyProperty = 0; 
    }

    public void MyMethod() {
        // Now, this line is safe because MyProperty is guaranteed to be initialized
        int value = MyProperty.GetHashCode(); 
    }
} 