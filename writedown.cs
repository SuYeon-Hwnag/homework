using System;

public class writeline
{
    public static void Main()
    {
        Console.WriteLine("Enter String:");
        string string1 = Console.ReadLine();
        
        Console.WriteLine("Enter String:");
        string string2 = Console.ReadLine();

        Console.Write(string1 + "\n");

        Console.Write(string2 + "\n");

        Console.WriteLine(string1);

        Console.WriteLine(string2);

        Console.WriteLine(string1 + "\n" + string2);

        Console.WriteLine($"{string1}\n{string2}");

    }
}