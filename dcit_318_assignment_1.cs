// DCIT318 - Assignment 1
// Student ID: [11356687]


using System;

namespace DCIT318Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an application to run:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.Write("Enter choice (1-3): ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GradeCalculator();
                    break;
                case 2:
                    TicketPriceCalculator();
                    break;
                case 3:
                    TriangleTypeIdentifier();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void GradeCalculator()
        {
            Console.Write("Enter a grade (0 - 100): ");
            int grade = int.Parse(Console.ReadLine());
            string result = "";

            if (grade >= 90) result = "A";
            else if (grade >= 80) result = "B";
            else if (grade >= 70) result = "C";
            else if (grade >= 60) result = "D";
            else result = "F";

            Console.WriteLine($"The letter grade is: {result}");
        }

        static void TicketPriceCalculator()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Your ticket price is: GHC{price}");
        }

        static void TriangleTypeIdentifier()
        {
            Console.Write("Enter side 1: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Enter side 3: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
    }
}
