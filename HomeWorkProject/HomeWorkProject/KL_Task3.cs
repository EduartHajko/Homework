using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkProject;

namespace HomeWorkProject
{
    public class Solution
    {
        //    //public static void Solution1()
        //    //{
        //    //    StringBuilder sb = new StringBuilder();
        //    //    Console.WriteLine("Type a word:");

        //    //    string input = Console.ReadLine();

        //    //    if (input.ToLower() != "stop")
        //    //    {
        //    //        sb.Append(input);
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("StringBuilder result" + sb.ToString());
        //    //    }

        //    //}

        //    //public static void Exercice6()
        //    //{

        //    //    try
        //    //    {
        //    //        Console.WriteLine("Write a number :");
        //    //        string input = Console.ReadLine();
        //    //        string[] Number = input.Split(",");

        //    //        int[] numbers = new int[Number.Length];
        //    //        for (int i = 0; i < numbers.Length; i++)
        //    //        {
        //    //            numbers[i] = Convert.ToInt32(Number[i]);

        //    //        }
        //    //        foreach (int number in numbers)
        //    //        {
        //    //            Console.WriteLine(number);
        //    //        }
        //    //    }
        //    //    catch (Exception  EX) 
        //    //    {

        //    //        throw EX;
        //    //    }

        //    //}

        //    //public static void Palindrome()
        //    //{

        //    //        int n, r, sum = 0, temp;
        //    //        Console.Write("Enter the Number: ");
        //    //        n = int.Parse(Console.ReadLine());
        //    //        temp = n;
        //    //        while (n > 0)
        //    //        {
        //    //            r = n % 10;
        //    //            sum = (sum * 10) + r;
        //    //            n = n / 10;
        //    //        }
        //    //        if (temp == sum)
        //    //            Console.Write("Number is Palindrome.");
        //    //        else
        //    //            Console.Write("Number is not Palindrome");


        //    //}

        //    //public static void Solution7()
        //    //{
        //    //    string value, reversedValue = "";
        //    //    Console.Write("Enter a string : ");
        //    //    value = Console.ReadLine();
        //    //    if (value != null)
        //    //    {
        //    //        for (int i = value.Length - 1; i >= 0; i--)
        //    //        {
        //    //            reversedValue += value[i].ToString();
        //    //        }
        //    //        if (reversedValue == value)
        //    //        {
        //    //            Console.WriteLine("String is a Palindrome String: {0} and Reversed String is: {1}", value, reversedValue);
        //    //        }
        //    //        else
        //    //        {
        //    //            Console.WriteLine("String is not a Palindrome String: {0} and Reversed String: {1}", value, reversedValue);
        //    //        }
        //    //    }

        //    //}



        //

        public static void TaskDictionnary()
        {
            IDictionary<string, string> ditari = new Dictionary<string, string>();
            ditari.Add("Username", "ABBA");
            ditari.Add("Password", "Norway@12");

            foreach (KeyValuePair<string, string> kvp in ditari)
            {
                if (ditari.ContainsKey("Username"))
                {
                    ditari[kvp.Key] = kvp.Value;
                }
                Console.WriteLine(kvp.Value);
                Console.WriteLine(kvp.Key);
                
            }
                //Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}

