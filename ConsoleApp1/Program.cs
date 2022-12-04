using System;
using System.Globalization;

namespace ConsoleApp1
{
    
    internal class Program
    {
        static void Polindrom(string str)
        {
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = Convert.ToInt32(str[i]);
            }
            int count = 0;
            if(arr.Length % 2 == 0)
            {
                for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
                {
                    if(arr[i] == arr[j])
                        count++;
                }
                if (count == arr.Length)
                    Console.WriteLine("True polindrom");
                else
                    Console.WriteLine("False polindrom");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");

            string str = Console.ReadLine();
            Polindrom(str);

            Website web = new Website();
            web.Print();

            Website web2 = new Website("youTube", "", "", "192.168.25.101");
            web2.Print();
            web2.SetIP();
            web2.Print();

            Shop shop = new Shop();
            shop.Print();

            Magazine mag = new Magazine("Auto", 2022, "hdddd", "3855383500956", "kop.eee");
            mag.Print();

        }
        
    }
}