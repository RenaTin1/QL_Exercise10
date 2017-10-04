using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serena Tindle- Exercise 10 -- Have user input if they're over 54' tall. If not they cannot ride the Raptor.

           bool ContinueProgram = true; //Declare and intialize bool

           while (ContinueProgram == true) //While statement
           { 
                //Variables
            double height;
            string UserOption;

            Console.WriteLine("Welcome to Raptor!!");
            Console.WriteLine("Please enter your height in inches: ");
            height = double.Parse(Console.ReadLine()); //read user input
                if (height < 54.0)
                {
                    Console.WriteLine("Sorry you cannot ride the Raptor! Try again Next year!");
                    TryAgain(UserOption);//call method for asking if they want to try again
                }
                else
                {
                    Console.WriteLine("Great!! You can ride the Raptor!");
                    TryAgain(UserOption);

                }
             
           }
 }

        static void TryAgain(string UserOption)
        {
            Console.WriteLine("Would you like to Continue? (n/y)"); //Try again method
            UserOption = Console.ReadLine();

            if (UserOption == "N" || UserOption == "No" || UserOption == "no")
            {
                ContinueProgram = false;
                Console.WriteLine("Goodbye!");
            }

        }


    }
    }
