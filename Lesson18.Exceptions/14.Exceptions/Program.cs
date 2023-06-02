try
{
    throw null;
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}

// Delay.
Console.ReadKey();