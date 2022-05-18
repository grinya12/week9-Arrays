using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            //"win a Jackpot"
            //"fall in love"
            //"get a love letter"
            //"miss the bus"
            //"see a unicorn un the street"

            //Приложение показывает в консоли предсказание для пользователя, выбранное случайным образом из приведенного выше списка.

            string[] fortune = { "win a Jackpot", "fall in love", "get a love letter", "miss the bus", "see a unicorn un the street" };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, fortune.Length);

            Console.WriteLine($"{fortune[randomIndex]}");

        }
    }
}
