using System;

//Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя
//программа переводит температуру из Фаренгейта в Цельсий 
//или наоборот.

namespace Task_6
{
    internal class Task_6
    {
        static void Main(string[] args)
        {
            bool setup = true; //if true celsium, if false farenheit
            Console.Write("Enter the value of temperature: ");
            double input_Tvalue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose, Celsium or Farenheit value is it\n 0 - Farenheit, 1 - Celsium: ");
            setup = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Your value is: {input_Tvalue}");
            if (setup)
            { Console.WriteLine($"in Farenheit: {input_Tvalue * 1.8 + 32}"); }
            else
            { Console.WriteLine($"in Celsium: {0.5555 * (input_Tvalue - 32)}"); }
        }
    }
}
