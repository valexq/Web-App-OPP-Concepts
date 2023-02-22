using System;

namespace WebApp_ConceptOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your day: ");
                int day = Convert.ToInt32(Console.ReadLine());

                var dateObject = new Date(year, month, day);
                Console.WriteLine("The day entered is: "+dateObject);
            }
            catch(Exception message)
            {
                Console.WriteLine(message);
            }
            
        }
    }
}
