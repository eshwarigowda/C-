using System;
public class Foreach
{
    public static void Run()
    {
        string[] cars = { "volvo", "BMW", "Ford"};
        foreach (string car in cars){
            Console.WriteLine(car);

        }    
    }
}