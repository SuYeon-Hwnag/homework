using System;
    
namespace stringint
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Write string -> ");
            string string1 = Console.ReadLine();
            int int1 = int.Parse(string1);
            float float1 = (float)int1;
            string string2 = float1.ToString();

        }
    }
}