/* author: Magaly Rodriguez
 * Purpose: Final project - New Patient form - Showcase of our knowledge / skills
 * Course: COMP 003A
 */

using System;
using System.Buffers;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Finalproject.COMP3A
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter your first name.");
            string firstName = Console.ReadLine();
            if (Regex.IsMatch(firstName, @"^[a-zA-Z]+$")) //detects if input Name uses alphabet
            {
                Console.WriteLine($"Your first name is: {firstName}");
            }

            else
            {
                Console.WriteLine("Invalid input. Enter letters only."); //else statement if incorrect input
            }
            
            

            Console.WriteLine("Enter your last name.");
            string lastName = Console.ReadLine();
            if (Regex.IsMatch(lastName, @"^[a-zA-Z]+$")) //detects if input lastName uses letters
            {
                Console.WriteLine($"Your last name is: {lastName}");
            }

            else
            {
                Console.WriteLine("Invalid input. Enter letters only."); //else statement if incorrect input
            }
             
            Console.WriteLine($"Your name is {lastName}, {firstName}"); //outputs last name then first name
            */

            patientName();
            SectionSeparator(); //method to separate sections

            Console.WriteLine("Enter your gender: M for male, F for female, or O for other only.");
            char gender = Convert.ToChar(Console.ReadLine());
            Gender(gender); //calls Gender method

            SectionSeparator();

            Console.WriteLine("Enter your birth year.");
            int year = Convert.ToInt32(Console.ReadLine());
            Birthyear(year); //calls Birthyear method
                      
            string[] questions = new string[10] //array that holds questions
            {   
                "What is your height in centimeters?",
                "What is your weight in lbs?",
                "What is your preferred phone number?",
                "Please list your health insurance.",
                "List any medical conditions.",
                "List any medications you are currently taking.",
                "What is your address?",
                "Please list one emergency contact.",
                "Name your current provider.",
                "State what brings you in today."
            };

            SectionSeparator();
            Question(questions); //calls method to ask for inputs             
        }        
        
        static string patientName()
        {
            string firstName;
            string lastName;
            string regexPattern = @"[^\w\s]"; //a pattern for Regex.IsMatch. it does not allow special characters.
            do
            {
                Console.WriteLine("Enter your first name.");
                firstName = Console.ReadLine();
                
                if (string.IsNullOrEmpty(firstName))
                {
                    Console.WriteLine("Invalid input. Enter letters only.");
                }

                else if (Regex.IsMatch(firstName, ("^[0-9]+$")))
                {
                    Console.WriteLine("Invalid input. Enter letters only.");
                }

                else if (Regex.IsMatch(firstName, regexPattern))
                {
                    Console.WriteLine("Invalid input. Enter letters only.");
                }                
            }

            while (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$")); //while statement re loops if firstName is not letters. 
            {
                Console.WriteLine($"Your first name is: {firstName}");              
            }

            do
            {
                Console.WriteLine("Enter your last name.");
                lastName = Console.ReadLine();

                if (string.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("Invalid input. Enter letters only.");
                }

                else if (Regex.IsMatch(lastName, ("^[0-9]+$")))
                {
                    Console.WriteLine("Invalid input. Enter letters only.");
                }

                else if (Regex.IsMatch(lastName, regexPattern))
                {
                    Console.WriteLine("Invalid input. Enter letters only.");
                }
            }

            while (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$")); //while statement re loops if firstName is not letters. 
            {
                Console.WriteLine($"Your last name is: {lastName}");
            }
            return firstName;
            return lastName;
        }


        /// <summary>
        /// asks for user input. if input is less than 1900 or over 2024 it will display the else option. Correct input will display the user's age.
        /// </summary>
        /// <param name="year">int input</param>
        static void Birthyear(int year)
        {

            if (year >= 1900 && year <= DateTime.Now.Year)
            {
                year = DateTime.Now.Year - year;
                Console.WriteLine($"You are {year} years old.");
            }

            else
            {
                Console.WriteLine("Invalid birth year. Enter a year between 1900 and" ,DateTime.Now.Year);
            }

        }

        /// <summary>
        /// asks for user input for either M, F, or O. char.ToUpper automatically converts input to uppercase. else statement executes if char is not M, F, or O. 
        /// </summary>
        /// <param name="gender">char input</param>
        static void Gender(char gender)
        {
            gender = char.ToUpper(gender);
            if (gender == 'M') 
            {
              
                Console.WriteLine("You entered: Male");                
            }

            else if(gender == 'F')
            {
                
                Console.WriteLine("You entered: Female");
            }

            else if(gender == 'O')
            {
                
                Console.WriteLine("You entered: Other");
            }
            else
            {
                Console.WriteLine("Invalid input. Select M, F, or O.");
            }            
        }

        /// <summary>
        /// using a foreach loop to display each question followed by user response which is stored in the string Answer. Empty Console.WriteLine to add a 
        /// space between each question and answer.
        /// </summary>
        /// <param name="questionnaireAnswer">string input to answer each question</param>
        static void Question(string[]questionnaireAnswer)
        {           
            
           foreach (var item in questionnaireAnswer)
            {
                Console.WriteLine(item);
                
                string[] storeAnswer = new string[10];
                
                for (int i = 0; i < storeAnswer.Length; i++) //for loop to loop through the array to then store input below.
                {
                    storeAnswer[i] = Console.ReadLine(); //stores input into the array storeAnswer                   
                }

                foreach(string itemAnswer in storeAnswer)
                {
                    Console.WriteLine(itemAnswer);
                }
            }
                      
        }    
        /// <summary>
        /// a simple section separator.
        /// </summary>
        static void SectionSeparator()
        {
            Console.WriteLine("".PadRight(50, '-'));            
        }
        
       
    }
}



