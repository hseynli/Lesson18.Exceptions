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
    // finally işlməyəcək (StackOverdlowException).
    while (true)
        Console.WriteLine("Finally");
}

void Method()
{
    int[] arr = new int[10];
    Console.WriteLine(arr);
    Method();
}