# calculator_Alice
OSSCA C# 콘솔 에플리케이션으로 만든 사칙연산 계산기

using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("간단한 계산기입니다. 연산을 선택하세요:");
                Console.WriteLine("1. 더하기");
                Console.WriteLine("2. 빼기");
                Console.WriteLine("3. 곱하기");
                Console.WriteLine("4. 나누기");
                Console.WriteLine("5. 종료");

                // 사용자의 선택을 읽어온다.
                int choice = Convert.ToInt32(Console.ReadLine());

                // 종료를 선택하면 루프를 빠져나가고 프로그램을 종료한다.
                if (choice == 5)
                {
                    Console.WriteLine("계산기를 종료합니다.");
                    break;
                }

                Console.Write("첫 번째 숫자를 입력하세요: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("두 번째 숫자를 입력하세요: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                // 사용자의 선택에 따라 연산을 수행합니다.
                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                            result = num1 / num2;
                        // 만약 0으로 나눌 수 없다면
                        else
                            Console.WriteLine("0으로 나눌 수 없습니다.");
                        break;
                    // 처음으로 돌아간다.
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        continue;
                }

                // 연산 결과를 출력한다.
                Console.WriteLine("결과: " + result);
            }
        }
    }
}
