using System;
using System.Linq;


namespace HomeWork_Array_
{
    internal class Program
    {
        static int [] summ(int[] arr1, int[]arr2)
        {
            int[] arr3 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            return arr3;
        }

        static int[,] summ(int[,] arr1, int[,] arr2)
        {
            int[,] arr3 = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; i < arr3.GetLength(1); i++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return arr3;
        }

        static int[] product1(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] * arr2[i];
            }
            return arr3;
        }

        static int[,] product1(int[,] arr1, int[,] arr2)
        {
            int[,] arr3 = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; i < arr3.GetLength(1); i++)
                {
                    arr3[i, j] = arr1[i, j] * arr2[i, j];
                }
            }
            return arr3;
        }

        static int[] productNumber(int[] arr1, int value)
        {
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i] * value;
            }
            return arr2;
        }

        static int[,] productNumber(int[,] arr1, int value)
        {
            int[,] arr2 = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; i < arr2.GetLength(1); i++)
                {
                    arr2[i, j] = arr1[i, j] * value;
                }
            }
            return arr2;
        }

        ///Exercise 3
        static string Cezar(string str, int kol)
        {
            string abetka = "";
            string text = "";
            for (int i = 65; i < 91; i++)
            {
                abetka += (char)i;
            }
            for (int i = 97; i < 123; i++)
            {
                abetka += (char)i;
            }
            int size = abetka.Length;
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                index = abetka.IndexOf(c);
                int indexAll = (index + kol) % size;
                text += abetka[indexAll];
            }
            return text;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1");
            Random random = new Random();
            int[] A = { 1, 2, 3, 4, 5 };

            int[,] B = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = Convert.ToInt32(random.Next(1, 100));
                }
            }



            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]} ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(A.Max());
            Console.WriteLine(A.Min());
            Console.WriteLine(A.Sum());
            Console.WriteLine("Array A % 2 : " + A.Where(i => i % 2 == 0).Sum());
            Console.WriteLine("Array A !% 2: " + A.Where(i => i % 2 != 0).Sum());
            int sum = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sum += B[i, j];
                }
            }
            Console.WriteLine("SUMM        : " + sum);
            int minValue = B[0, 0];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (minValue > B[i, j])
                        minValue = B[i, j];
                }
            }
            Console.WriteLine("MIN         : " + minValue);

            int maxValue = B[0, 0];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (minValue < B[i, j])
                        minValue = B[i, j];
                }
            }
            Console.WriteLine("MAX         : " + minValue);

            ulong product = 1;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    product *= (ulong)B[i, j];
                }
            }
            Console.WriteLine("PRODUCT     : " + product);



            sum = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (j % 2 != 0)
                            sum += B[i, j];
                    }
                }
            }
            Console.WriteLine("SUMM COL %2 : " + sum);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Exercise 2");
            int[,] arr = new int[5, 5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-100, 100);

                }
            }

            maxValue = arr[0, 0];
            minValue = arr[0, 0];
            int Ymin = 0;
            int Xmin = 0;
            int Ymax = 0;
            int Xmax = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                    if (maxValue < arr[i, j])
                    {
                        maxValue = arr[i, j];
                        Ymax = i;
                        Xmax = j;

                    }

                    if (minValue > arr[i, j])
                    {
                        minValue = arr[i, j];
                        Ymin = i;
                        Xmin = j;
                    }

                    if (minValue > arr[i, j])
                    {
                        minValue = arr[i, j];
                        Ymin = i;
                        Xmin = j;

                    }

                }
                Console.WriteLine();
            }
            sum = 0;
            int kol = 0;
            if (Ymin * 10 + Xmin < Ymax * 10 + Xmax)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (minValue == arr[i, j] || kol > 0)
                        {
                            sum += arr[i, j];
                            kol = 1;
                            if (maxValue == arr[i, j])
                                kol = 0;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (maxValue == arr[i, j] || kol > 0)
                        {
                            sum += arr[i, j];
                            kol = 1;
                            if (minValue == arr[i, j])
                                kol = 0;
                        }
                    }
                }

            }

            Console.WriteLine("MIN : " + minValue);
            Console.WriteLine("MAX : " + maxValue);
            Console.WriteLine("SUMM: " + sum);

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Exercise 3");
            Console.WriteLine(Cezar("Vell", 55));
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Exercise 4");
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 6, 7, 8, 9, 10 };
            int[] array3 = new int[5];

            array3 = summ(array, array2);
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
            array3 = product1(array, array2);
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();

            array3 = productNumber(array, 3);
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Exercise 5");
            int k = 0;
            int result = 0;
            string str10 = Console.ReadLine();
            string[] str11 = str10.Split('-', '+');
            string[] str3 = new string[str11.Length - 1];
            for (int i = 0; i < str10.Length; i++)
            {
                if (str10[i].ToString() == "+" || str10[i].ToString() == "-")
                {
                    str3[k] = str10[i].ToString();
                    k++;
                }
            }
            result = Convert.ToInt32(str11[0]);
            for (int i = 0; i < str3.Length; i++)
            {
                if (str3[i] == "+")
                    result += Convert.ToInt32(str11[i + 1]);
                else
                    result -= Convert.ToInt32(str11[i + 1]);
            }
            Console.WriteLine(result);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Exercise 6");
            string str6 = "today is a good day for walking. i will try to walk near the sea.";
            string[] str9 = str6.Split('.');
            for (int i = 0; i < (str9.Length - 1); i++)
            {
                if (i == 0)
                    str6 = str9[i].Substring(0, 1).ToUpper() + str9[i].Substring(1) + ". ";
                else
                    str6 += str9[i].Substring(1, 1).ToUpper() + str9[i].Substring(2) + ". ";
            }

            Console.WriteLine(str6);


            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Exercise 7");
            string str = "To be, or not to be, that is the question," +
                "\r\nWhether 'tis nobler in the mind to suffer" +
                "\r\nThe slings and arrows of outrageous fortune," +
                "\r\nOr to take arms against a sea of troubles," +
                "\r\nAnd by opposing end them? To die: to sleep;" +
                "\r\nNo more; and by a sleep to say we end" +
                "\r\nThe heart-ache and the thousand natural shocks" +
                "\r\nThat flesh is heir to, 'tis a consummation" +
                "\r\nDevoutly to be wish'd. To die, to sleep";
            string str2 = "";
            Console.WriteLine(str);
            Console.WriteLine("\n\n");
            Console.WriteLine(str2 = str.Replace("die", "***"));


        }
    }
}