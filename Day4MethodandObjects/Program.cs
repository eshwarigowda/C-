using System;

class Program { 
    //mrthod with multiple parameters
    static void Mymehtod(string fname,int age)
    {
        //Code to be executed
        Console.WriteLine("Code get executed");
        Console.WriteLine(fname +" is "+ age);
    }
    //Default parameter method
    static void Defaultparameter(string country = "India")
    {
        Console.WriteLine(country);

    }

    //return value method
    public static int Returnvalue(int x,int y)
    {
        return x + y;
    }

    //named argument method-argument with key(order of argument does not matter
    public static void Namedargs(string c1,string c2,string c3)
    {
        Console.WriteLine("Named Arguments");
        Console.WriteLine("The youngest child is " + c3);

    }
    //Method overloading
    public static int Plusmethod(int x,int y)
    {
        return x + y;
    }
    public static double Plusmethod(double x, double y)
    {
        return x + y;
    }


    //main method
    static void Main(string[] args)
    {
        //call a method-Mymethod
        Mymehtod("Stefan",23);
        Mymehtod("Damon", 24);

        //Call a default method
        Defaultparameter("India");
        Defaultparameter("America");
        Defaultparameter("Africa");
        Defaultparameter();

        //Call a returnvalue method
        Console.WriteLine("Adding two numbers : ");
        int z = Returnvalue(10, 5);
        Console.WriteLine("x+y is : " +z);

        //Named argument
        
        Namedargs(c1: "Adam", c3: "Alexander", c2: "John");

        //Method overloading
        int num1 = Plusmethod(10, 5);
        double num2 = Plusmethod(9.5, 7.5);
        Console.WriteLine(num1);
        Console.WriteLine(num2);

    }
}