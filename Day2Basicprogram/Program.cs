//importing sysytem
using System;

namespace firstProgram
{
    class Program
    {
        static void Main(String[] args)
        {
            //Variable and datatype
            string fname = "Eshwari";
            int age = 20;
            int myInt = 9;

            //implicit casting
            double mydouble = myInt;

            //Explicit casting
            int ageInFiveYears = age + (int)5.5;

            //Output
            Console.WriteLine("name:" + fname);
            Console.WriteLine("age:" + age);
            Console.WriteLine("double:" + mydouble);
            Console.WriteLine("Age in 5 years :" + ageInFiveYears);
            

        }
    }
}

