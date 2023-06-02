Console.OutputEncoding = System.Text.Encoding.UTF8;
int a = 1, n = 2;

try
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sıfıra bölmə cəhdi.");
    Console.WriteLine("a / (2 - n) = {0}", a / (2 - n));
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Xətanın emalı.");
    Console.WriteLine(e.Message);
}
finally
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.Black;
}

Console.WriteLine("Press any key...");

// Delay.
Console.ReadKey();