using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(String[] args)
    {
        //Encapsulation
        Accountencapsulation a1 = new Accountencapsulation();
        a1.Balance = 200;
        Console.WriteLine("Encapsulation");
        Console.WriteLine(a1.Balance);

        //Inheritance
        Cow c1 = new Cow();
        Console.WriteLine("Inheritance");
        Console.WriteLine(c1.food);
        c1.noise();

        //sealed class
        //Panda p1 = new Panda();
        //Console.WriteLine(p1.move);



        //polymorphism
        Vehicle v1 = new Vehicle();
        Vehicle car = new Car();
        Vehicle bike = new Bike();

        Console.WriteLine("Polymorphism");
        v1.move();
        car.move();
        bike.move();

        //abstraction
        Console.WriteLine("Abstraction");
        Parrot par = new Parrot();
        par.MakeSound();
        par.Fly();

        //Interface
        Console.WriteLine("Interface");
        Jeep j1 = new Jeep();
        j1.start();
        j1.stop();

        //enum
        Console.WriteLine("enum");
        Status status = Status.Pending;
        Console.WriteLine((int)status);

        //Exception
        Console.WriteLine("Exception");
        Division d1 = new Division();
        d1.div();

        Fileoperation f1 = new Fileoperation();
        f1.Files();

        
    }
}
