using System;
public class Strings
{
    public static void Run()
    {
        string greet = "Hello world";
        //name
        string firstname = "John";
        string lastname = "Smith";
        string name = firstname + lastname;
        //String interpolation
        string fname = "stefan ";
        string lname = "Salvatore";


        Console.WriteLine(greet);
        Console.WriteLine(greet.ToUpper());
        Console.WriteLine(greet.ToLower());
        Console.WriteLine(greet.Length);
        //name
        Console.WriteLine(firstname);
        Console.WriteLine(lastname);
        Console.WriteLine(name);
        //String Interpolation
        Console.WriteLine($"Full name is:{fname} {lname}");

        //Access String
        Console.WriteLine(greet[2]);
        Console.WriteLine(greet.IndexOf("r"));
    }
}
