
public class UserInput
{
    public static void Run()
    {
        Console.WriteLine("enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is:" + age);
    }
}
