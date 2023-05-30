using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Делить на ноль невозможно");
                        continue;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Некорректная операция");
                    continue;
            }

            Console.WriteLine("Результат: " + result);
           
                break;
            
        }

        Console.WriteLine("Программа завершена");
    }
}