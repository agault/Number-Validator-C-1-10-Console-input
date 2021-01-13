using System;

namespace ContolFlowPractice
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //CW enter a valid number:
            Console.WriteLine("Please enter a valid number between 1-10:");
            //USER INPUT Console.readline()
            int userInput = Convert.ToInt32(Console.ReadLine());
            //IF VALID(1<=x <= 10): CW(ToString(Readline stored as var) + "is valid")
            int min = 1;
            int max = 10;
            if (min <= userInput == true && userInput<=max)
            {
                Console.WriteLine( userInput + " is Valid");
            }
            //ELSE CW("Please enter a valid number" ).
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
