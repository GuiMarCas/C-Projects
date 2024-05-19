using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";
            while (answer == "yes")
            {
                int number = GetValidNumber();
                int[] list = Functions.FillArray(number);
                int sum = Functions.AddValues(list);

                Console.WriteLine("The sum of all the digits is " + sum);

                Console.WriteLine("Do you wish to continue? (yes/no)");
                answer = Console.ReadLine().ToLower();

                while (answer != "yes" && answer != "no") 
                {
                    Console.WriteLine("Invalid answer");
                    Console.WriteLine("Do you wish to continue? (yes/no)");
                    answer = Console.ReadLine().ToLower();
                }
            }
        }
        static int GetValidNumber() 
        {
            int number;
            while (true) 
            {
                Console.WriteLine("Introduce a number");
                string input = Console.ReadLine();
                while (!int.TryParse(input, out number)) 
                {
                    Console.WriteLine("Introduce a valid number");
                    input = Console.ReadLine();
                }

                if (input.Length > 9)
                {
                    Console.WriteLine("Input is too long.");
                    continue;
                }
                return number;
            }
        }
    }
    public class Functions
    {
        public static int[] FillArray(int input)
        {
            string stringInput = Convert.ToString(input);
            int[] array = new int[stringInput.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(stringInput[i].ToString());
            }
            return (array);
        }

        public static int AddValues(int[] input) 
        {
            int total = 0;
            foreach (int i in input) 
            {
                total += i;
            }
            return (total);
        }
    }
}
