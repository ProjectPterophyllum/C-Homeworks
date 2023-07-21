using System;

//Пользователь вводит шестизначное число. После чего 
//пользователь вводит номера разрядов для обмена цифр. 
//Например, если пользователь ввёл один и шесть — это 
//значит, что надо обменять местами первую и шестую 
//цифры.
//Число 723895 должно превратиться в 523897.
//Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.

namespace Task_4
{
    internal class Task_4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the six digits value: ");
            var input = Console.ReadLine();
            //Console.WriteLine(input.Length); //Debug
            if (input.Length != 6) Console.WriteLine("Error. Give me the six digit value!");
            else
            {
                char[] output = input.ToCharArray();
                Console.Write("Enter the first digit for swap: ");
                int first = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Enter the second digit for swap: ");
                int second = int.Parse(Console.ReadLine()) - 1;
                char tmp;
                tmp = output[first];
                output[first] = output[second];
                output[second] = tmp;
                Console.WriteLine(output);
            }
        }
    }
}
