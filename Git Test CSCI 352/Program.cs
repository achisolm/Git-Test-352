using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test_CSCI_352
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int myNum = r.Next(1, 100);
            int yourNum = -1;
            int guesses = 0;
            Console.WriteLine("I'm thinking of a number between 1 and 100:");
            Console.WriteLine("For debug: myNum = " + myNum);

            while (yourNum != myNum)
            {
                Console.WriteLine("Guess a number: ");
                yourNum = Convert.ToInt32(Console.ReadLine());
                guesses += 1;

                if (yourNum < myNum)
                {
                    Console.WriteLine("Too low");
                }
                else if (yourNum > myNum)
                    Console.WriteLine("Too high");
            }
            Console.WriteLine("Guessed in " + guesses);
            Console.ReadKey();
        }
    }
}
