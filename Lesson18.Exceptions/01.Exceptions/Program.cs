Console.OutputEncoding = System.Text.Encoding.UTF8;

int a = 1, n = 2;

try
{
    // Sıfıra bölmə cəhdi.
    a = a / (2 - n);

    Console.WriteLine("a = {0}", a);
}
catch (Exception e)
{
    Console.WriteLine("Xətanın emalı.");
    Console.WriteLine(e.Message);
}

// Delay.
Console.ReadKey();