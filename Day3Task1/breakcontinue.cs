using System;
public class Breakcontinue
{
    public static void run()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i == 4)
            {
                Console.WriteLine(i);
                break;
                
            }

            for (int j = 0; j < 5; j++)
            {
                if (j == 4)
                {
                    break;
                }
                Console.WriteLine(j);
            }
        }
    }
}