﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    internal class A_K_Task3
    {
        public static void Solution()
        {

            /*StringBuilder s = new StringBuilder();

            Console.WriteLine("Please input a string:");
            string input = Console.ReadLine();

            if (input.ToLower() != "stop")
            {
                s.Append(input);
            }
            else
            {

            }
            Console.WriteLine("The final string is: " + input.ToString());*/

        }

        //exercise:2
        public static void Solution2()
        {
            Console.WriteLine("Please input the nr of elements you want the array to have: ");
            string sSize = Console.ReadLine();
            int arrSize = Convert.ToInt32(sSize);
            int[] arr = new int[arrSize];
            

            Console.WriteLine("Input " + arrSize + " elements in the array :\n");
            

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element with index - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nElements in array are: ");
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\n");                   
            }

            Console.WriteLine("\nElements in array displayed in reverse order are: ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i] + "\n");
            }
        }

        public static void Solution3()
        {
            string value, reversedValue = "";
            Console.Write("Enter a string : ");
            value = Console.ReadLine();
            if (value != null)
            {
                for (int i = value.Length - 1; i >= 0; i--)
                {
                    reversedValue += value[i].ToString();
                }
                if (reversedValue == value)
                {
                    Console.WriteLine("String is a Palindrome String: {0} and Reversed String is: {1}", value, reversedValue);
                }
                else
                {
                    Console.WriteLine("String is not a Palindrome String: {0} and Reversed String: {1}", value, reversedValue);
                }
            }
            
        }

        public static void Solution4()
        {

        }

    }
}
