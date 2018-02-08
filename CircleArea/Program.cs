using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a radius: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double r))
            {
                if (r < 0)
                {
                    Console.WriteLine("You must enter a valid number.");
                    Console.ReadLine();
                }
                else
                {
                    double area = 3.14 * r * r;
                    Console.WriteLine("The area of the circle is: " + area);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Radius must be numeric.");
                Console.ReadLine();
            }
        }
    }
}
