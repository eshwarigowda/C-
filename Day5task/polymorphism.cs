using System;
//parent class
public class Vehicle
{
    public string color = "black";
    public void move()
    {
        Console.WriteLine("Vehicle is moving");
    }

}


//child class
class Car : Vehicle
{
    public void move()
    {
        Console.WriteLine("car is moving");
    }

}
class Bike : Vehicle
{
    public void move()
    {
        Console.WriteLine("Bike is moving");
    }
}