Console.OutputEncoding = System.Text.Encoding.UTF8;

ClassWithException instance = new ClassWithException();
//instance.CatchInner(); // Çağırmağa cəhd etmək.
try
{
    instance.CatchInner();
}
catch (Exception exception)
{
    Console.WriteLine("Exception caught: {0}", exception.Message);
    Console.WriteLine("Inner Exception : {0}", exception.InnerException.Message);
}

// Delay.
Console.ReadKey();


public class ClassWithException
{
    public void ThrowInner()
    {
        throw new Exception("Daxili xəta!");
    }

    public void CatchInner()
    {
        try
        {
            this.ThrowInner();
        }
        catch (Exception e)
        {
            throw new Exception("Xarici xəta!", e);
        }
    }
}