using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action2
{
    class Program
    {
        public static event Action myOwnAction;
        public class HI
        {
            
            private void SomethingHappend()
            {
                myOwnAction?.Invoke();
            }
        }
        
        
        static void Main(string[] args)
        {
            while (true)
            {
                // 입력 받기
                Console.WriteLine("input: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        myOwnAction += One;
                        break;
                    case "2":
                        myOwnAction += Two;
                        break;
                    case "3":
                        myOwnAction += Three;
                        break;
                    case "4":
                        myOwnAction?.Invoke();
                        break;
                    default:
                        break;
                }
                if (input == "n")
                {
                    break;
                }

            }
            Console.ReadKey();
        }
        static void One()
        {
            Console.WriteLine("Hi World");
        }
        static void Two()
        {
            Console.WriteLine("Hi World");
        }
        static void Three()
        {
            Console.WriteLine("Hi World");
        }
    }

}
