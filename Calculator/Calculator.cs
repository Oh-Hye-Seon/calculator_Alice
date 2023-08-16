using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("간단한 계산기 프로그램입니다.");
            Console.WriteLine("사칙연산 기호(+, -, *, /) 중 하나를 입력하세요.");

            // 사용자로부터 사칙연산 기호를 입력받습니다.
            string operation = Console.ReadLine();

            Console.WriteLine("첫 번째 숫자를 입력하세요:");
            // 사용자로부터 첫 번째 숫자를 입력받아 숫자로 변환합니다.
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("두 번째 숫자를 입력하세요:");
            // 사용자로부터 두 번째 숫자를 입력받아 숫자로 변환합니다.
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            // 입력된 사칙연산 기호에 따라서 해당 연산을 수행합니다.
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // 0으로 나누는 경우를 처리합니다.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("0으로 나눌 수 없습니다.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("잘못된 연산 기호입니다.");
                    return;
            }

            // 결과를 출력합니다.
            Console.WriteLine($"결과: {result}");

            // 결과를 표로 출력합니다.
            Console.WriteLine("\n계산 결과 표:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|   숫자 1   |   숫자 2   |   연산   |   결과   |");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"|    {num1}    |    {num2}    |    {operation}    |    {result}    |");
            Console.WriteLine("-----------------------");
        }
    }
}
