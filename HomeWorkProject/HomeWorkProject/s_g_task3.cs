using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{

    internal class s_g_task3
    {
        public static void solution()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Type in text");
            string input = Console.ReadLine();
            if (input.ToLower() != "stop")
            {
                sb.Append(input);
            }
            else
            {
                Console.WriteLine("Result of string builder " + sb.ToString());
            }
        }
        //exercise 2
        public static void Exercise2()
        {
            Console.WriteLine("Write a number :");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            int[] array = new int[5];
            Console.Write("element-{0}");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}: ", array[i]);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nElements in array are: ");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        //exercise 3 with palindromes
        public static void Exercise3()
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
        //exercise 4 with dictionary
        public static void Exercise4()
        {
            Console.WriteLine("Enter Username:");
            string input = Console.ReadLine();
            IDictionary<string, string> userNames = new Dictionary<string, string>();
            {
                userNames.Add("Tom", "12345");
                userNames.Add("Albert", "abcde");
                userNames.Add("Dennis", "qwerty");

            };
            foreach (KeyValuePair<string, string> kvp in userNames)
            {
                if (kvp.Key.Equals(input))
                {
                    Console.WriteLine("Username is correct");
                    string pass = Console.ReadLine();
                    foreach (KeyValuePair<string, string> kvn in userNames)
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

    
