using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            Console.WriteLine("0~100 의 int 중 하나 입력");
            int int1 = int.Parse(Console.ReadLine());


            // 스탑워치 놓기
            Stopwatch stopwatch = new Stopwatch();

            randomNumber=randNum();
            stopwatch.Start(); // 시작




            // 답안 제출
            Console.WriteLine("랜덤한 숫자가 당신이 입력한 숫자의 배수냐?");
            Console.WriteLine("Input YES or NO");
            string Answer = Console.ReadLine();

            // 정답
            string RealAnswer;
            if(randomNumber % int1== 0)
            {
                RealAnswer = "YES";
            }
            else
            {
                RealAnswer = "NO";
            }

            // 정답 확인
            if(Answer == RealAnswer)
            {
                // 랜덤 숫자 띄움
                Console.WriteLine(randomNumber);

;
                // 스탑워치 멈추기
                stopwatch.Stop();
                float totoalTime = stopwatch.ElapsedMilliseconds / 1000; //초
                // 시간 띄우기
                Console.WriteLine(totoalTime);
            }
            else
            {
                Console.WriteLine("Error");
            }

            // 계속 할지 묻기
            Console.WriteLine("계속 진행?");
            Console.WriteLine("Input YES or NO");
            string Keep = Console.ReadLine();

            if (Keep == "Yes")
            {
                // 랜덤 숫자 띄우기부터 시작
            }
            else
            {
                // 종료
            }

        }
        static int randNum()
        {
            // randomNumber가 0~100사이의 랜덤한 정수
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine(randomNumber);
            return randomNumber;
        }

    }
}
