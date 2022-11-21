using System;
using System.Globalization;


namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Exercise 1");
            Console.WriteLine("Enter number 1 - 100!");
            int a;
            string str;
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            if (a >= 1 && a <= 100)
            {
                if (a % 3 == 0 && a % 5 == 0)
                {
                    Console.WriteLine("Fizz, Buzz");
                }
                else if (a % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (a % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine("Wrong range of numbers");
            }

            Console.WriteLine("Exercise 2");
            Console.WriteLine("The first number is the value, the second number is the percentage. Enter first number");
            double value1, percentage;
            str = Console.ReadLine();
            value1 = Convert.ToDouble(str);
            Console.WriteLine("Enter second number");
            str = Console.ReadLine();
            percentage = Convert.ToInt32(str);
            Console.WriteLine("Result: " + value1 * (percentage / 100));



            Console.WriteLine("Exercise 3");
            str = "";
            Console.WriteLine("Enter four number!");
            for (int i = 0; i < 4; i++)
            {
                str += Console.ReadLine();
            }
            int b = Convert.ToInt32(str);
            Console.WriteLine(b + 1);


            Console.WriteLine("Exercise 4");
            //int value;
            Console.WriteLine("Enter a six-digit number");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[6];
            arr[0] = number / 100000;
            arr[1] = (number / 10000) % 10;
            arr[2] = (number / 1000) % 10;
            arr[3] = (number / 100) % 10;
            arr[4] = (number / 10) % 10;
            arr[5] = number % 10;

            Console.WriteLine("Enter the indices of the numbers you want to change");
            value = Convert.ToInt32(Console.ReadLine());
            string str2 = Console.ReadLine();
            int value2 = Int32.Parse(str2);
            number = arr[value - 1];
            arr[value - 1] = arr[value2 - 1];
            arr[value2 - 1] = number;
            str2 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str2 += arr[i];
            }
            Console.WriteLine(str2);

            Console.WriteLine("Exercise 5");
            Console.WriteLine("Enter the day of the week");
            DateTime data = DateTime.Parse(Console.ReadLine());
            if (data.Month == 1 || data.Month == 2 || data.Month == 12)
                Console.WriteLine("Winner " + data.DayOfWeek);
            else if (data.Month == 3 || data.Month == 4 || data.Month == 5)
                Console.WriteLine("Spring " + data.DayOfWeek);
            else if (data.Month == 6 || data.Month == 7 || data.Month == 8)
                Console.WriteLine("Summer " + data.DayOfWeek);
            else if (data.Month == 9 || data.Month == 10 || data.Month == 11)
                Console.WriteLine("Autumn " + data.DayOfWeek);

            Console.WriteLine("Exercise 6");
            Console.Write("t: ");
            double result = 0;
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. C, 2. F;");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    result = (value1 - 32) * 5 / 9;
                    break;
                case 2:
                    result = (value1 * 9 / 5) + 32;
                    break;
            }
            Console.WriteLine(Math.Round(result, 1));

            Console.WriteLine("Exercise 7");
            Console.WriteLine("Enter two numbers");
            number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number <= number2)
            {
                for (int i = number; i <= number2; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
            }
            else 
            {
                for (int i = number2; i <= number; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
            }
            
            
            
        }
    }
}
