using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taskid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1- c# program wheter a user´s number is pos, neg or zero 

            /*Console.WriteLine("Hello! Insert any number you like");
            int userNumber;

            Console.WriteLine("Enter any number:");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber > 0)
            {
                Console.WriteLine($"{userNumber} number is positive");
            }
            else if (userNumber < 0)
            {
                Console.WriteLine($"{userNumber} number is negative");
            }
            else
            {
                Console.WriteLine($"{userNumber}  is zero");
            }
            Console.ReadLine(); */

            //Task2- user number is divisible by 5 and 11 or not
            /*Console.WriteLine("Hello! Insert any number you like.");
            int userNumber;

            Console.WriteLine("Enter any number:");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 5==0)
            {
                Console.WriteLine("Number is divisible by 5"); 
            }
            else if (userNumber% 11==0)
            {
                Console.WriteLine("Number is divisble by 11 ");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 or 11");
            }
            Console.ReadLine(); */

            //Task3- user number is even or odd
            /*Console.WriteLine("Hello! Insert any number you like.");
            int userNumber;

            Console.WriteLine("Enter any number:");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Number is even"); 
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

            Console.ReadLine();*/

            //Task4- users input is vowel or smt else
            Console.WriteLine("Hello! Insert any letter you like.");
            string userLetter;

            Console.WriteLine("Enter any letter you like:");
            userLetter = Console.ReadLine();

            if (userLetter) 
            {
                Console.WriteLine("Letter is s vowel");
            }
            else
            {
                Console.WriteLine("Letter is not a vowel");
            }

            Console.ReadLine();
        }
        //Task5- asks user input a number (1-7) and print the corresponding day of week (monday- sunday)
    }
}
