using System;
//parent class
public class Animal
{
    public string food = "grass";
     
}


//child class
class Cow:Animal
{
    public void noise()
    {
        Console.WriteLine("mmoooooo");
    }

}
//sealed class
sealed class Bird
{
    public string move = "fly";
}

//class Panda:Bird
//{
//    public void sleep()
//    {
//        Console.WriteLine("panda sleeps");
//    }

//}

