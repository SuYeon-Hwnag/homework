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
            string YesNO;
            float aa = 0, cc = 0;
            string cal;
            float result = 0;

            do
            {
                Console.WriteLine("Input int1: ");
                aa = float.Parse(Console.ReadLine());
 
                Console.WriteLine("Input int2: ");
                cc = float.Parse(Console.ReadLine());

                // 사칙연산 뭐 할지 묻기
                Console.WriteLine("Input +,-,* or /: ");
                cal = Console.ReadLine();

                // 계산하기
                Calculate(ref aa, ref cal ,ref cc, ref result);

                // 계산 끝나고 물어보기
                Console.WriteLine("Do you want to keep going? Write Yes or No");
                YesNO = Console.ReadLine();
            }
            while (YesNO == "Yes");
        }

        static void Calculate(ref float a, ref string b, ref float c, ref float result)
        {
            switch (b)
            {

                case "+":
                    result = a + c;
                    break;
                case "-":
                    result = a - c;
                    break;
                case "*":
                    result = a * c;
                    break;
                case "/":
                    result = a / c;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine("result = {0}",result);


        }
    }
}