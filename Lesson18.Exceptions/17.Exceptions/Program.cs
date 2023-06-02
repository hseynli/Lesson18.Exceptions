Console.OutputEncoding = System.Text.Encoding.UTF8;

int x = 1;
int y = 0;

try
{
    int result1 = x / y;
    int result2 = y / x;
}
catch (DivideByZeroException) when (y == 0)
{
    Console.WriteLine("y sıfıra bərabər olmalı deyil.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}