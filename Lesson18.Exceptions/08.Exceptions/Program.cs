Console.OutputEncoding = System.Text.Encoding.UTF8;
try
{
    throw new UserException();
}
catch (UserException userException)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Xətanın emalı 1:");
    userException.Method();

    try
    {
        throw userException;
    }
    catch (UserException exception)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Xətanın emalı 2:");
        exception.Method();
    }
}
finally
{
    Console.ForegroundColor = ConsoleColor.Gray;
}

Console.WriteLine("Press any key...");

// Delay.
Console.ReadKey();


class UserException : Exception
{
    public void Method()
    {
        Console.WriteLine("Mənim xətam!");
    }
}