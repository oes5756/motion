using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("간단한 계산기 프로그램");
            Console.WriteLine("1. 더하기");
            Console.WriteLine("2. 빼기");
            Console.WriteLine("3. 곱하기");
            Console.WriteLine("4. 나누기");
            Console.WriteLine("5. 종료");
            Console.Write("원하는 작업을 선택하세요 (1-5): ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.");
                continue;
            }

            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("올바른 작업 번호를 선택하세요.");
                continue;
            }

            if (choice == 5)
            {
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            }

            Console.Write("첫 번째 숫자 입력: ");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("숫자를 입력하세요.");
                continue;
            }

            Console.Write("두 번째 숫자 입력: ");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("숫자를 입력하세요.");
                continue;
            }

            double result = 0;
            string operation = "";

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    operation = "더하기";
                    break;
                case 2:
                    result = num1 - num2;
                    operation = "빼기";
                    break;
                case 3:
                    result = num1 * num2;
                    operation = "곱하기";
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("0으로 나눌 수 없습니다.");
                        continue;
                    }
                    result = num1 / num2;
                    operation = "나누기";
                    break;
            }

            Console.WriteLine($"결과: {num1} {operation} {num2} = {result}");
        }
    }
}
