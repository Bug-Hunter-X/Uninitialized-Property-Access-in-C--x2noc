public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize to default value
    }

    public void MyMethod()
    {
        int value = this.MyProperty;
        Console.WriteLine(value);
    }
}