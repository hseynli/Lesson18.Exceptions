Console.OutputEncoding = System.Text.Encoding.UTF8;

Exception ex = new Exception("Custom exceptions");

try
{
    throw ex;
}
catch (Exception e)
{
    Console.WriteLine("Xətanın emalı.");
    Console.WriteLine(e.Message);
}

// Delay.
Console.ReadKey();