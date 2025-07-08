using System;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Constructor");
        //Car objects
        Car c1 = new Car("Mustang",2000);
        //c1.model = "Mustang";
        Console.WriteLine(c1.color + " " + c1.speed + " " + c1.model);

        Console.WriteLine(c1.model);

        //call a method
        c1.Move();


        Console.WriteLine("Constructor");
        Car c2 = new Car("Astra",2001);
        //c2.model = "Astra";
        Console.WriteLine(c2.color + " " + c2.speed + " " + c2.model);

        //call a method
        c2.Move();

    }
}
