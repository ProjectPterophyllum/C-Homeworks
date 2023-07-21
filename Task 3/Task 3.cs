using System;

//Пользователь вводит с клавиатуры четыре цифры. 
//Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
//сформировать число 1578.

namespace Task_3
{
    internal class Task_3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the how much numbers you want to enter: ");
            int numbers_size = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbers_size];
            int fullNumber = 0;
            bool breaking = false;
            Console.WriteLine($"Enter {numbers_size} numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                int tmp = int.Parse(Console.ReadLine());
                if (tmp < 10)
                {
                    numbers[i] = tmp;
                    fullNumber = int.Parse(fullNumber.ToString() + numbers[i].ToString());
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter only digit! Error.");
                    breaking = true;
                    break;
                }
            }
            if (!breaking)
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]}\t");
                    Console.WriteLine($"\nYour number is: {fullNumber}");
                }
        }
    }
}
