using System;

public class Division
{
    public void div() {
        try
        {
            int a = 10;
            int b = 0;
            int div = a / b;
            Console.WriteLine(div);
        }
        catch(Exception e)
        {
            Console.WriteLine("Cant divide by zero");
        }
        finally
        {
            Console.WriteLine("Finished");
        }

     }
}