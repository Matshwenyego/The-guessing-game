using System;

namespace theguessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            int input = 0;
            int count = 0;
            DateTime startTime = DateTime.Now;
            DateTime endTime;
            Random rnd = new Random();

            //Input from user
            Console.WriteLine("Enter an integer between 0 and 100");
            input = Int32.Parse(Console.ReadLine());

            for (int x = 0; x < 100; x++)
            {
                count++;

                //Random numbers from computer
                int cpuInteger = rnd.Next(1, 99);
                Console.WriteLine( (x+1)+ ".     "+ cpuInteger);

                //Check if the users number is equals to the cpu's
                if (cpuInteger == input)
                {
                    //Users number matches one of the cpu's random number
                    endTime = DateTime.Now;
                    Console.WriteLine("Yey!! you won");
                    Console.WriteLine("The number " + input + " was found at index " + count + " after " + count + " attempts");
                    Console.WriteLine("After " + endTime.Second + " seconds");
                    Console.ReadLine();
                }
            }

            //Users number did not match any of the cpu's random number
            Console.WriteLine("You lose!! You couldn't guess the number");
            Console.ReadLine();


        }
    }
}
