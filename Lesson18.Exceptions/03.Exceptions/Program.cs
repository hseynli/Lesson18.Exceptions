try
{
    throw new Exception("Custom exception");
}
catch (Exception e)
{
    Console.WriteLine("Xətanın emalı.");
    Console.WriteLine(e.Message);
}

// Delay.
Console.ReadKey();