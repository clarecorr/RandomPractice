using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            Console.WriteLine(random.Next(0, 10));
            Console.WriteLine(random.Next(0, 10));
            Console.WriteLine(random.Next(0, 10));
            Console.WriteLine(random.Next(0, 10));

            string[] words = { "Paper", "Rock", "Scissors" };
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            string saying = "You can never have too much cake";
            Console.WriteLine(words[random.Next(0, 3)]);
            Console.WriteLine(numbers[random.Next(0, numbers.Length)]);
            Console.WriteLine(saying[random.Next(0, saying.Length)]);

        }
    }
}
