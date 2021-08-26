using System;

namespace EX13Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //OPG 1
            /*
            int[] tal = { 25, 28, 15, 35, 14 };

            for (int i = 0; i < tal.Length; i++)   //OPGAVE 13.1
            {
                Console.WriteLine(tal[i]);
            }
            */
            //OPG 2
            /*
            string[] names = { "Troels", "Emil", "Nichlas", "Rasmus", "Jan", "William" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Random rnd = new Random();
            int Y = rnd.Next(0, 6);
            Console.WriteLine();
            Console.WriteLine("Kong " + names[Y]);
            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */
            //OPG 3
            /*
            int[] numbers = { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };
            //Array.Sort(numbers);                                         //Sætter tal i rækkefølge
            Array.Reverse(numbers);                                        //Udskriver variablen numbers baglæns
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */

            //OPG 4
            Console.WriteLine();
            int[] tal = { 1, 4, 7, 9, 33, 100, 45, 88, 2, 59 };
            for (int i = 0; i < tal.Length; i++)
            {
                Random rnd = new Random();
                int Y = rnd.Next(0, 11);
                Console.WriteLine(tal[Y]);
            }

            Console.ReadKey();
        }
    }
}
