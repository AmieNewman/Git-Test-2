using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomnumber = 0;
            int guesses = 0;
            //random number and number of guesses 
          //  Random classs = new Random();
          //  randomnumber = classs.Next(starting, ending +1);

            Console.WriteLine("Please give me a starting number");
            string thestart = Console.ReadLine();
            int starting = Int32.Parse(thestart);
            Console.WriteLine("Please give me an ending number");
            string theend = Console.ReadLine();
            int ending = Int32.Parse(theend);

            Random classs = new Random();
            randomnumber = classs.Next(starting, ending + 1);
            //asking for the details
            Console.WriteLine("Now please try to guess a number between " + thestart + " and " + theend + ".");
            string guess = Console.ReadLine();
            int numguess = Int32.Parse(guess);

          

            Console.WriteLine(numguess);

            while (randomnumber != numguess)
            {
                if (randomnumber > numguess)
                {
                    Console.WriteLine("You guessed too low, guess again please.");
                }
                else
                {
                    Console.WriteLine("You guessed too high, guess again please.");
                }
                Console.WriteLine("Guess a number now: ");

                guesses++;
                guess = Console.ReadLine();
                numguess = Int32.Parse(guess);
            }

            Console.WriteLine("YAY. FINALLY YOU DID SOMETHING RIGHT. And it only took " + guesses + " guesses." );
              //this reaction is by no means a reflection of the programmers feelings towards its users and completely random. 
              //it is a joke.  
            Console.ReadKey();

        }
    }
}
