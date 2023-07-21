using System;

//Пользователь вводит с клавиатуры два числа. Первое 
//число — это значение, второе число процент, который 
//необходимо посчитать. Например, мы ввели с клавиатуры 
//90 и 10. Требуется вывести на экран 10 процентов от 90. 
//Результат: 9.

namespace C__Homeworks
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number value: ");
            var value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number percent: ");
            var percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{percent} % from value is: {(double)percent / 100 * (double)value}");
        }
    }
}
