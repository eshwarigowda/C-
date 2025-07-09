using System;
interface Ivehicle
{
    public void start();
}
interface Ivehicles
{
    public void stop();

}

//multiple inheritance
class Jeep : Ivehicle, Ivehicles
{
    public void start()
    {
        Console.WriteLine("Jeep started");
    }
    public void stop()
    {
        Console.WriteLine("Jeep stopped");
    }
}