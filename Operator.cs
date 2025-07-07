using System;
public class Operator
{
    
    public static void Run()
    {
        int a = 20;
        int b = 15;
        //Arithmetic operator
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
        Console.WriteLine(a++);
        Console.WriteLine(b--);

        //Comparision Operator
        Console.WriteLine(a>b);
        Console.WriteLine(a < b);
        Console.WriteLine(a == b);
        Console.WriteLine(a >= b);
        Console.WriteLine(a <= b);
        Console.WriteLine(a != b);

        //Logical operator
        Console.WriteLine(a < 5 && a < 6);
        Console.WriteLine(a > 10 || a > 30);
        Console.WriteLine(!(a > 5 && a < 10));
    }
    
}