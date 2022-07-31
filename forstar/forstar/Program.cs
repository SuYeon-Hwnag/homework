using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forstar
{
    class Program
    {
        static void Main(string[] args)
        {
            // MakeStar 불러옴
            MakeStar();

        }

        static void MakeStar()
        {
            // "*" 은 star라고 하고 5 4 3 2 1이 됨
            // " " 은 empty라고 하고 0 2 4 6 8이 됨
            for (int i = 0 ; i < 5; i++)
            {
                for (int star1 = 5-i; ; star1--)
                {
                    if (star1 >= 1)
                    { Console.Write("*"); }
                    else
                        break;
                }
                for (int empty = 0; ; empty ++)
                {
                    if (empty < i*2)
                    { Console.Write(" "); }
                    else
                        break;
                }
                for (int star2 = 5-i; ; star2--)
                {
                    if (star2>= 1)
                    { Console.Write("*"); }
                    else
                        break;
                }
                Console.WriteLine();

            }

        }
    }
}
