namespace Finalproject.COMP3A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name.");
            string name = Console.ReadLine();
            if (name is not string)
            {


                Console.WriteLine("Enter your last name.");
                string lastName = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Name is not valid. Enter letters only.");
            }

            Console.WriteLine("Enter your birth year.");
            int year = Convert.ToInt32(Console.ReadLine());
            Birthyear(year);

            



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
            }

            else
            {
                Console.WriteLine("Invalid birth year.");
            }
             Console.WriteLine($"{year}");
        }
    }
}

