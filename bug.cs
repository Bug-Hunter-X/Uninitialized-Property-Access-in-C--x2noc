public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized can lead to unpredictable behavior or exceptions.
        int value = this.MyProperty; //Uninitialized Property
        Console.WriteLine(value);
    }
}