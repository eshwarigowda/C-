using System;
using System.IO;
class Fileoperation
{
    
    public void Files()
    {
        string filePath = "example.txt";

        File.WriteAllText(filePath, "How are you!!\n");

        // Append text
        File.AppendAllText(filePath, "Hello world!\n");

        // Read and print
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }
}