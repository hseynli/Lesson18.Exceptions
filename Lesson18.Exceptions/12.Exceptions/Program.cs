try
{
    throw new Exception();
}
catch (Exception)
{
    throw new Exception();

    // və ya ...

    while (true)
        Console.WriteLine("Catch");
}
finally
{
    // finally işləməyəcək! Çünki catch bloku işini bitirməyəcək.
    while (true)
        Console.WriteLine("Finally");
}