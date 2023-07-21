using System;

//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
//остатка) нужно вывести слово Fizz. Если число кратно 5
//нужно вывести слово Buzz. Если число кратно 3 и 5 нужно 
//вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно 
//вывести само число.
//Если пользователь ввел значение не в диапазоне от 1
//до 100 требуется вывести сообщение об ошибке.

namespace C__Homeworks
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            Int32 number = 0;
            do
            {
                Console.Write("Enter the number between 1 and 100: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number <= 100)
                {
                    if (number % 3 == 0)
                    { Console.WriteLine("Fizz"); }
                    else if (number % 5 == 0)
                    { Console.WriteLine("Buzz"); }
                    else { Console.WriteLine($"Your number is:{number}"); }
                }
                else
                    Console.WriteLine("Your number is out of range between 1 and 100.");
            }
            while (number != 0);
        }
    }
}
