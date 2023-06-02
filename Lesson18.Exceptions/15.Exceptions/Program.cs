try
{
    //throw new Exception("Exception");
    throw new MyExceptionA("MyExceptionA");
    //throw new MyExceptionB("MyExceptionB");
}
catch (MyExceptionB e)
{
    Console.WriteLine(e.Message);
}
catch (MyExceptionA e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// Delay.
Console.ReadKey();

class MyExceptionA : Exception
{
    public MyExceptionA(string message)
        : base(message)
    {
    }
}

class MyExceptionB : MyExceptionA
{
    public MyExceptionB(string message)
        : base(message)
    {
    }
}