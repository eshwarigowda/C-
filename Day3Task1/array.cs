using System;
public class Arraytest
{
    public static void Run()
    {
        string[] cars = { "volvo", "BMW", "Ford" };
        for(int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[0]);
        }
    }
}