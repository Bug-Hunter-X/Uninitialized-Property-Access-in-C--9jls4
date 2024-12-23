public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property

    public void MyMethod()
    {
        //Now MyProperty is initialized with default value 0.
        Console.WriteLine(MyProperty); // This will always print 0
        MyProperty = 10; //Assign a new value
        Console.WriteLine(MyProperty); //prints 10
    }

    public ExampleClass() {  //Initialize the property in constructor
        MyProperty = 5;
    }
}