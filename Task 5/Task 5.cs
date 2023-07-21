using System;

//Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
//Например, если введено 22.12.2021, приложение должно 
//отобразить Winter Wednesday.

namespace Task_5
{
    internal class Task_5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date in format DD.MM.YYYY: ");
            string input = Console.ReadLine();
            DateTime date = new DateTime();
            date = DateTime.Parse(input);
            if (date.Month <= 2 || date.Month == 12) Console.WriteLine("Now is Winter");
            else if (date.Month >= 3 && date.Month <= 5) Console.WriteLine("Now is Spring");
            else if (date.Month >= 6 && date.Month <= 8) Console.WriteLine("Now is Summer");
            else Console.WriteLine("Now is Autumn");
            Console.WriteLine($"{date.DayOfWeek}");
        }
    }
}
