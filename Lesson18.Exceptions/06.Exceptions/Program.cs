Console.OutputEncoding = System.Text.Encoding.UTF8;

try
{
    throw new UserException();
}
catch (UserException userException)
{
    Console.WriteLine("Xətanın emalı.");
    userException.Method();

    try
    {
        FileStream fs = File.Open(@"C:\NonExistentFile.log", FileMode.Open);
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}

// Delay.
Console.ReadKey();


class UserException : Exception
{
    public void Method()
    {
        Console.WriteLine("Mənim xətam!");
    }
}