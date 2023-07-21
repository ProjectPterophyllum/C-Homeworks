using System;

//Пользователь вводит с клавиатуры два числа. Нужно 
//показать все четные числа в указанном диапазоне. Если 
//границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
//ввел 20 и 11, требуется нормализация, после которой 
//начало диапазона станет равно 11, а конец 20.

namespace Task_7
{
    internal class Task_7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            int[] input = new int[2] { 0, 0 };
            for (int i = 0; i < 2; i++)
                input[i] = int.Parse(Console.ReadLine());
            if (input[0] > input[1])
            {
                int tmp = input[0];
                input[0] = input[1];
                input[1] = tmp;
            }
            Console.Write($"Your range is: {input[0]}->{input[1]}\nEven numbers between your range: ");
            for (int i = input[0]; i < input[1]; i++)
                if (i % 2 == 0) Console.Write($"{i}\t");
        }
    }
}
