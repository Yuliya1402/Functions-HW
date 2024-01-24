using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или q для выхода");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена");
                break;
            }

            if (int.TryParse(input, out int num))
            {
                int digitSum = CalculateDigitSum(num);

                if (digitSum % 2 == 0)
                {
                    Console.WriteLine("Программа завершена");
                    break;
                }
                else
                {
                    Console.WriteLine("Сумма цифр числа нечетная.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }

    static int CalculateDigitSum(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}

