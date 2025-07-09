using System;
abstract class Birds
{
    // Abstract method (must be implemented in child)
    public abstract void MakeSound();

    // Concrete method (common to all birds)
    public void Fly()
    {
        Console.WriteLine("Bird is flying...");
    }
}
class Parrot : Birds
{
    public override void MakeSound()
    {
        Console.WriteLine("parrot says twee twee");

    }
    
}