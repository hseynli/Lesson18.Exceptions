try
{
    Method();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    // finally işləyəcək (OutOfMemoryException).
    Console.WriteLine("Finally");
}

// Delay.
Console.ReadKey();

void Method()
{
    int[] arr = new int[100000000];
    Console.WriteLine(arr);
    Method();
}