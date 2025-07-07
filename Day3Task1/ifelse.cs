using System;
public class Ifelse
{
    public static void Run()
    {
        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening";
        Console.WriteLine("short hand if else");
        Console.WriteLine(result);

        int age = 25;
        //if else
        Console.WriteLine("ifElse");
        if (age > 18)
        {
            Console.WriteLine("Congratulations you are eligible for voting");
        }
        else
        {
            Console.WriteLine("You are not eligible for voting");
        
        }
    }
}