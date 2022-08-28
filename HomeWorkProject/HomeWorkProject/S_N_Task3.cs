using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    internal class S_N_Task3
    {
        //public static void Solution()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    Console.WriteLine("Type in text");
        //    string input = Console.ReadLine();
        //    if (input.ToLower() != "stop")  
        //    {
        //        sb.Append(input);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Result of string builder " + sb.ToString());
        //    }

        //}

        //public static void Excercise2()
        //{
        //    Console.WriteLine("Write a number :");
        //    string input = Console.ReadLine();
        //    int result = Int32.Parse(input);
        //    int[] array = new int[10];
        //    Console.Write("Element - {0}" + i);
        //    array[i] = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("{0}", array[i]);
        //        array[i] = i;
        //    }
        //    Console.WriteLine("\n");

        //    foreach (int i in array)
        //    {
        //        Console.WriteLine(i);
        //    }

        ////}

        ////public static void Palindrome()
        //{
            //int n, r, sum = 0, temp;
            //Console.Write("Enter the Number: ");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = (sum * 10) + r;
            //    n = n / 10;
            //}
            //if (temp == sum)
            //    Console.Write("Number is Palindrome.");
            //else
            //    Console.Write("Number is not Palindrome");





            //    string value, reversedValue = "";
            //    Console.Write("Enter a string : ");
            //    value = Console.ReadLine();
            //    if (value != null)
            //    {
            //        for (int i = value.Length - 1; i >= 0; i--)
            //        {
            //            reversedValue += value[i].ToString();
            //        }
            //        if (reversedValue == value)
            //        {
            //            Console.WriteLine("String eshte nje Palindrome: {0} dhe String i anasjellte eshte: {1}", value, reversedValue);
            //        }
            //        else
            //        {
            //            Console.WriteLine("String nuk eshte nje Palindrome: {0} dhe String i anasjellte: {1}", value, reversedValue);
            //        }
            //    }

            //}
            public static void Solution4() // ushtrim klase me Dictionary
        {
            
            string input = Console.ReadLine();
            IDictionary <string, string> usernames = new Dictionary<string, string>();
            usernames.Add("Serin", "1234");
            usernames.Add("Rusi", "123456");
            usernames.Add("Oli", "12345678");

            foreach (KeyValuePair<string, string> kvp in usernames)
            {
                if (kvp.Key.Equals(input))
                {
                    Console.WriteLine("Username is correct");
                    string pass = Console.ReadLine();
                    

                    foreach (KeyValuePair<string, string> kvn in usernames)
                    {
                        if (!kvn.Value.Equals(pass))
                        {
                            Console.WriteLine("Password is Correct");
                            break;
                        }
                    }
                        }
            
            }





        }




    }
}


