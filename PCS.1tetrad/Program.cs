using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float one, two, result;
            char sign;

            Console.WriteLine("Добро пожаловать в калькулятор.");
            Console.WriteLine("Вам необходимо ввести первое число, затем знак действия (+, -, *, /), и второе число.");

            Console.Write("Введите первое число: ");
            one = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите знак действия: ");
            sign = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число: ");
            two = Convert.ToSingle(Console.ReadLine());

            if (sign == '+')
            {
                result = one + two;
                Console.WriteLine("Сумма ваших чисел равна " + result);
            }
            else if (sign == '-')
            {
                result = one - two;
                Console.WriteLine("Разность ваших чисел равна " + result);
            }
            else if (sign == '*')
            {
                result = one * two;
                Console.WriteLine("Произведение ваших чисел равно " + result);
            }
            else if (sign == '/')
            {
                if (two == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равен нулю.");
                }
                else
                {
                    result = one / two;
                    Console.WriteLine("Частное ваших чисел равно " + result);
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели неверный знак.");
            }

            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}