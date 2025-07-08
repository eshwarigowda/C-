using System;

public class Car
{
    //class memebers

    //fiels/property
    //public access modifier
    public string color = "White";
    public int speed = 200;
    public string model;
    public int year;

    //private access modifier(Can't be accessed outside the class)
    private int price = 10000000;

    //Constructor with parameter
    public Car(string modelName, int years)
    {
        model = modelName;
        year = years;


    }
    

    //methods
    public void Move()
    {
        Console.WriteLine("Move Method");
        Console.WriteLine(color);
        Console.WriteLine(speed);
        Console.WriteLine(model);
        Console.WriteLine("Car is Moving");
    }
}