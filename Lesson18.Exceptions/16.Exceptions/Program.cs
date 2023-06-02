Console.OutputEncoding = System.Text.Encoding.UTF8;
Square("12"); // 
Square("ab"); // !Xəta

PureSquare("ab");

void Square(string data)
{
    int x = int.Parse(data);
    Console.WriteLine($"Ədədin kvadratı {x}: {x * x}");
}

void PureSquare(string data)
{
    if (int.TryParse(data, out var x))
    {
        Console.WriteLine($"Ədədin kvadratı {x}: {x * x}");
    }
    else
    {
        Console.WriteLine("İnput data səhv daxil edilib.");
    }
}