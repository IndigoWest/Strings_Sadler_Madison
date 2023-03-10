// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace Strings_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when application starts
        static void Main(string[] args)
        {
            // Asks the user to input a character
            Console.WriteLine("User, please input a character.");
            // Gives user input to enter a character
            char myChar = Console.ReadKey().KeyChar;
            // Checks if the character user entered is a letter
            bool isLetter = Char.IsLetter(myChar);
            // Prints results in Console
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}.");

            // Asks user to answer an escape room riddle
            Console.WriteLine("User, please answer this escape room riddle: You're in a room with concrete walls, a concrete floor, and a concrete roof. Everything is blank and you're alone in the room. You don't know how you got there. All there is in the room to aid your escape is a table and a mirror. What do you do to escape?");
            // Assigns user input to answer the riddle
            string myString = Console.ReadLine();
            // Asks the user to enter a word
            Console.WriteLine("User, please enter a word.");
            // Assigns user input to enter a word
            string myStringTwo = Console.ReadLine();
            // Checks if word is in the answer user inputted to riddle
            bool isIn = myString.Contains(myStringTwo);
            // Prints if word is in the answer user inputted to riddle
            Console.WriteLine($"{myStringTwo} exists in {myString}, {isIn}.");
            // Gives user answer to the riddle
            Console.WriteLine("Also, here's the actual answer to the riddle, User: I look in the mirror. I see what I saw. I take the saw. I cut the table in half. Two halves equals a hole.");
        }
    }
}
