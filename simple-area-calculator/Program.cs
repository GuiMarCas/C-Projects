using System;
namespace SimpleAreaCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continu3 = true;
            while (continu3 == true)
            {
                Console.WriteLine("Welcome to area calculator");
                Console.WriteLine("1 - Triangle\n2 - Rectangle\n3 - Circle\nSelect your shape (number): ");
                string input = Console.ReadLine();

                while (input != "1" & input != "2" & input != "3")
                {
                    Console.WriteLine("Please, write a correct number");
                    Console.WriteLine("1 - Triangle\n2 - Rectangle\n3 - Circle\nSelect your shape (number): ");
                    input = Console.ReadLine();
                }

                // Añadir control de overflow de double
                if (input == "1")
                {
                    double bse;
                    double height;

                    Console.WriteLine("Introduce the base of the triangle: ");
                    string bseInput = Console.ReadLine();

                    while (double.TryParse(bseInput, out bse) == false)
                    {
                        Console.WriteLine("Introduce a valid input");
                        Console.WriteLine("Introduce the base of the triangle: ");
                        bseInput = Console.ReadLine();
                    }

                    bse = double.Parse(bseInput);

                    Console.WriteLine("Introduce the height of the triangle: ");
                    string heightInput = Console.ReadLine();

                    while (double.TryParse(heightInput, out height) == false)
                    {
                        Console.WriteLine("Introduce a valid input");
                        Console.WriteLine("Introduce the height of the triangle: ");
                        heightInput = Console.ReadLine();
                    }

                    height = double.Parse(heightInput);

                    double area = GeometryCalculator.TriangleArea(bse, height);
                    Console.WriteLine("The area of your triangle is " + area);
                }

                if (input == "2")
                {
                    double length;
                    double height;

                    Console.WriteLine("Introduce the length of the rectangle: ");
                    string lengthInput = Console.ReadLine();

                    while (double.TryParse(lengthInput, out length) == false)
                    {
                        Console.WriteLine("Introduce a valid input");
                        Console.WriteLine("Introduce the length of the triangle: ");
                        lengthInput = Console.ReadLine();
                    }

                    length = double.Parse(lengthInput);

                    Console.WriteLine("Introduce the height of the rectangle: ");
                    string heightInput = Console.ReadLine();

                    while (double.TryParse(heightInput, out height) == false)
                    {
                        Console.WriteLine("Introduce a valid input");
                        Console.WriteLine("Introduce the height of the rectangle: ");
                        heightInput = Console.ReadLine();
                    }

                    height = double.Parse(heightInput);

                    double area = GeometryCalculator.RectangleArea(height, height);
                    Console.WriteLine("The area of your rectangle is " + area);
                }

                if (input == "3")
                {
                    double radius;

                    Console.WriteLine("Introduce the radius of the circle: ");
                    string radiusInput = Console.ReadLine();

                    while (double.TryParse(radiusInput, out radius) == false)
                    {
                        Console.WriteLine("Introduce a valid input");
                        Console.WriteLine("Introduce the radius of the circle: ");
                        radiusInput = Console.ReadLine();
                    }

                    radius = double.Parse(radiusInput);

                    double area = GeometryCalculator.CircleArea(radius);
                    Console.WriteLine("The area of your circle is " + area);
                }

                Console.WriteLine("Do you want to continue? (y/n): ");
                string answer = Console.ReadLine();

                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("please, answer only 'y' or 'n'");
                    Console.WriteLine("Do you want to continue? (y/n): ");
                    answer = Console.ReadLine();
                }
                if (answer == "n")
                {
                    break;
                }
            }


        }
    }
    public static class GeometryCalculator
    {
        public static double TriangleArea(double bse, double height)
        {
            double area = (bse / 2) * height;
            return area;
        }
        public static double RectangleArea(double length, double height)
        {
            double area = length * height;
            return area;
        }
        public static double CircleArea(double radius)
        {
            const double pi = 3.14159265358979323846;
            double area = pi * (radius * radius);
            return area;
        }
    }
}

