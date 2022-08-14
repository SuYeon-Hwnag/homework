using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);

            // Add(a,b,re );

            List<string> sList = new List<string>();
            sList.Add("값");
            sList.Add("마");
            sList.RemoveAt (0);


        }

        static void Swap(ref int n1, ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
            // Value 답을 직접적으로 가져옴
            // Ref 


        }

        static void Add (ref int n1, ref int n2, out int result)
        {
            result = n1 + n2;
        }

        class Aclass
        {
            int Hp;
            int Attack;

            public void init(int a1, int a2)
            {
                Hp = a1;
                Attack = a2;
            }
        }
    }
}
