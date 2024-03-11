namespace Finalproject.COMP3A
{
    using System;
    using System.Buffers;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your first name.");
            string name = Console.ReadLine();
            if (Regex.IsMatch(name, @"^[a-zA-Z]+$")) //detects if input Name uses alphabet
            {
                Console.WriteLine($"Your first name is: {name}");
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
             
            Console.WriteLine($"{lastName}, {name}"); //outputs last name then first name

            SectionSeparator(); //method to separate sections

            Console.WriteLine("Enter your gender: M for male, F for female, or O for other only.");
            char gender = Convert.ToChar(Console.ReadLine());
            Gender(gender); //calls Gender method

            SectionSeparator();

            Console.WriteLine("Enter your birth year.");
            int year = Convert.ToInt32(Console.ReadLine());
            Birthyear(year); //calls Birthyear method
                      
            string[] questions = new string[] //array that holds questions
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

        /// <summary>
        /// asks for user input. if input is less than 1900 or over 2024 it will display the else option. Correct input will display the user's age.
        /// </summary>
        /// <param name="year">int input</param>
        static void Birthyear(int year)
        {

            if (year >= 1900 && year <= 2024)
            {
                year = DateTime.Now.Year - year;
                Console.WriteLine($"You are {year} years old.");
            }

            else
            {
                Console.WriteLine("Invalid birth year. Enter a year between 1900 and 2024.");
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
              
                Console.WriteLine("Male");                
            }

            else if(gender == 'F')
            {
                
                Console.WriteLine("Female");
            }

            else if(gender == 'O')
            {
                
                Console.WriteLine("Other");
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
        /// <param name="answer">string input to answer each question</param>
        static void Question(string[]answer)
        {           
            
           foreach (var item in answer)
            {
                Console.WriteLine(item);
                Console.Write("Response: ");
                string Answer = Console.ReadLine();
                Console.WriteLine();                              
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



