using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 3;
            string s1 = "Hi";

            Console.WriteLine("{0}{1}", i1, s1);
            Console.WriteLine($"{i1}{s1}");
            Console.WriteLine(i1+""+ s1);
            Console.WriteLine(@"{i1}{s1}"); // 그대로 {}{}출력됨
            Console.WriteLine($@"{i1}{s1}");

            string name = "Mark";
            var date = DateTime.Now; // $ 쓰면 {} 안에 있는 name이 Mark로 출력
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
        }

    }
}
