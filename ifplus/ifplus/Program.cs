using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifplus
{
    class Program
    {
        static void Main(string[] args)
        {


            // a 'b' c 결과 도출 -> 매소드로 따로 뺄 것

            do while (true)
            {
                Console.WriteLine("Do you want keep going? Write Yes or No");
                string yesno = Console.ReadLine();
                if (yesno = Yes)
                {
                    // 계산하기
                }
            }
        }
        // 계산 하기
        string a, b, c;
        Console.WriteLine("Input int1: ");
            a = Console.ReadLine();
            int int1 = int.Parse(a);

        Console.WriteLine("Input +,-,* or /: ");
            b = Console.ReadLine();

            Console.WriteLine("Input int2: ");
            c = Console.ReadLine();
            int int2 = int.Parse(c);
    }
}
