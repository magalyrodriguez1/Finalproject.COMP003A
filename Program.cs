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
            patientName();
            // SectionSeparator(); //method to separate sections

            Console.WriteLine("Enter your gender: M for male, F for female, or O for other only.");

            Gender(); //calls Gender method

            //SectionSeparator();

            Birthyear(); //calls Birthyear method

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

                if (string.IsNullOrEmpty(firstName)) //checks for null or empty input
                {
                    Console.WriteLine("Invalid input. Enter letters only.");
                }

                else if (Regex.IsMatch(firstName, ("^[0-9]+$"))) //checks for numbers
                {
                    Console.WriteLine("Invalid input. Enter letters only.");
                }

                else if (Regex.IsMatch(firstName, regexPattern))//checks for pattern created above
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
            return firstName + lastName;            
        }

        /// <summary>
        /// asks for user input. if input is less than 1900 or over 2024 it will display the else option. Correct input will display the user's age.
        /// </summary>
        /// <param name="year">int input</param>
        static int Birthyear()
        {
            int year;
            Console.WriteLine("Enter your birth year.");
            year = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (year >= 1900 && year <= DateTime.Now.Year)
                {
                    year = DateTime.Now.Year - year;
                    Console.WriteLine($"You are {year} years old.");
                    return year;
                }
                else
                {
                    Console.WriteLine($"Invalid birth year. Enter a year between 1900 and {DateTime.Now.Year}.");
                    year = Convert.ToInt32(Console.ReadLine());
                    year = DateTime.Now.Year - year;
                    Console.WriteLine($"You are {year} years old.");
                }
            }

            while (year < 1900 || year > DateTime.Now.Year);
            return year; //for some reason, if I included a try/ block, i would get error that Birthyear did not return anything. So I did not include it unfortunately.
        }

        /// <summary>
        /// asks for user input for either M, F, or O. char.ToUpper automatically converts input to uppercase. else statement executes if char is not M, F, or O. 
        /// </summary>
        /// <param name="gender">char input</param>
        static string Gender()
        {
            string gender;

            do
            {
                Console.WriteLine("Enter your gender. M, F, or O only.");

                gender = Console.ReadLine();
                gender = gender.ToUpper();
                if (gender != "M" && gender != "F" && gender != "O") 

                {
                    Console.WriteLine("Invalid input.");
                }
            }

            while (gender != "M" && gender != "F" && gender != "O");
            {
            }

            if (gender == "F")
            {
                gender = "Female";
            }

            else if (gender == "O")
            {
                gender = "Other";
            }
            else if (gender == "M")
            {
                gender = "Male";

            }
            Console.WriteLine($"You selected {gender}.");
            return gender;
        }


        /// <summary>
        /// using a foreach loop to display each question followed by user response which is stored in the string Answer. Empty Console.WriteLine to add a 
        /// space between each question and answer.
        /// </summary>
        /// <param name="questionnaireAnswer">string input to answer each question</param>
        static string[] Question(string[] questionnaireAnswer)
        {
            string[] answer = new string[questionnaireAnswer.Length];
            for (int i = 0; i < questionnaireAnswer.Length; i++)
            {
                Console.WriteLine(questionnaireAnswer[i]);
                string answerInput;
                do
                {
                    answerInput = Console.ReadLine();

                    if (string.IsNullOrEmpty(answerInput)) //checks for empty input
                    {
                        Console.WriteLine("Input is not valid as it is empty. Please try again.");
                    }
                }
                while (string.IsNullOrEmpty(answerInput));
                answer[i] = answerInput;
            }
            return answer;
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
    



