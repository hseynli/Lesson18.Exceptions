Console.OutputEncoding = System.Text.Encoding.UTF8;

try
{
    throw new UserException();
}
catch (UserException e)
{
    Console.WriteLine("Xətanın emalı.");
    e.Method();
}

// İstifadəçi xətası yaratmaq üçün Exception klasından miras almaq lazımdır
class UserException : Exception
{
    public void Method()
    {
        Console.WriteLine("Mənim xətam!");
    }
}