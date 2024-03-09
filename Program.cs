﻿namespace Finalproject.COMP3A
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
            if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Enter your last name.");
                string lastName = Console.ReadLine();
                if (Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine($"{lastName}, {name}");
                }
            }
            else
            {
                Console.WriteLine("Name is not valid. Enter letters only.");
            }

            Console.WriteLine("Enter your gender: M, F, or O only.");
            char gender = Convert.ToChar(Console.ReadLine());
            Gender(gender);          

                Console.WriteLine("Enter your birth year.");
                int year = Convert.ToInt32(Console.ReadLine());
                Birthyear(year);

            int i;
            string[] answer = new string[9]; //9 size array

            Question(answer);
        }
            /*
            static void Name(string name)
            {
                if (name is string)
                {
                    //string lastName = (Console.ReadLine);
                    Console.WriteLine($"{lastName}, {name}");

                }
                else
                {
                    Console.WriteLine("Name is not valid. Enter letters only.");
                }
            */

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

        static void Gender(char gender)
        {
            gender = char.ToUpper(gender);
            if (gender == 'M') 
            {
              
                Console.WriteLine("Male");                
            }

            if (gender == 'F')
            {
                
                Console.WriteLine("Female");
            }

            if (gender == 'O')
            {
                
                Console.WriteLine("Other");
            }
            else
            {
                Console.WriteLine("Invalid input. Select M, F, or O.");
            }
        }

        static void Question(string[]answer)
        {

            string[] questions = new string[] { "What is your height in centimeters?", "What is your weight in lbs?", "What is your preferred phone number?",
            "Please list your health insurance.", "List any medical conditions.", "List any medications you are currently taking.","What is your address?",
            "Please list one emergency contact.", "Name your current provider.", "State what brings you in today."};
            
           foreach (var item in questions)
            {
                Console.WriteLine(item);
            }
            
            for(int i = 0; i < 9; i++)
            {
                answer[i] = Console.ReadLine();
            }



            Console.WriteLine("Questions and answers");
            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
            
            
        }

        
        }
    }

//maybe create a method that displays full profile? // .GetInfo ?

