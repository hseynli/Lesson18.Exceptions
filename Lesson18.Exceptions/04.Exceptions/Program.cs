using System.Collections;

Console.OutputEncoding = System.Text.Encoding.UTF8;

try
{
    MyClass instance = new MyClass();
    instance.MyMethod();
}
catch (Exception e)
{
    Console.WriteLine("Üzvün adı:                  {0}", e.TargetSite);
    Console.WriteLine("Üzvü təyin edən klasın adı: {0}", e.TargetSite.DeclaringType);
    Console.WriteLine("Üzvün tipi:                 {0}", e.TargetSite.MemberType);
    Console.WriteLine("Message:                    {0}", e.Message);
    Console.WriteLine("Source:                     {0}", e.Source);
    Console.WriteLine("Help Link:                  {0}", e.HelpLink);
    Console.WriteLine("Stack:                      {0}", e.StackTrace);

    foreach (DictionaryEntry de in e.Data)
        Console.WriteLine("{0} : {1}", de.Key, de.Value);
}

// Delay.
Console.ReadKey();


class MyClass
{
    public void MyMethod()
    {
        Exception exception = new Exception("Mənim xətam");

        exception.HelpLink = "http://MyCompany.com/ErrorService";
        exception.Data.Add("Xətanın səbəbi: ", "Test xəta");
        exception.Data.Add("Xətanın yaranma vaxtı: ", DateTime.Now);

        throw exception;
    }
}