using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plusminus
{
    class Program
    {
        static void Main(string[] args)
        {
            float float1;
            float float2;

            Console.WriteLine("Input float1: ");
            float1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Input float2: ");
            float2 = float.Parse(Console.ReadLine());

            Console.WriteLine("+: {0}", float1 + float2);
            Console.WriteLine("-: {0}", float1 - float2);
            Console.WriteLine("*: {0}", float1 * float2);
            Console.WriteLine("/: {0}", float1 / float2);
            Console.WriteLine("%: {0}", float1 % float2);

            Console.ReadKey();

        }
    }
}
