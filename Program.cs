using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_stringChange
{
    /*
     #2  Rotate the characters in a string by a given input 
     and have the overflow appear at the beginning, 
     e.g. “MyString” rotated by 2 is “ngMyStri”.  
     */
    class Program
    {
        static void Main(string[] args)
        {
            processUserInput();
        }

        public static void processUserInput()
        {
            //get user input
            string userInput = string.Empty;
            Console.WriteLine("We will take your input, remove the last two characters, and place them in front of your input.\n");
            Console.Write("Your word: ");
            userInput = Console.ReadLine();

            //rip the user input at two. this could be done in a multiple ways. if string length, const variable. etc. 
            string ripString = userInput.Substring((userInput.Length - 2), 2);
            string newstring = userInput.Substring(0, userInput.Length - ripString.Length);

            Console.WriteLine("Ripped input: " + ripString);
            Console.WriteLine("Combined input: " + (ripString + newstring));
            Console.ReadLine();
        }
    }
}
