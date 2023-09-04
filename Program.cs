using System;

class program
{
    static void Main()
    {
        Console.WriteLine("구구단을 출력할 숫자를 입력하세요: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"{num}단을 출력합니다:");

        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}