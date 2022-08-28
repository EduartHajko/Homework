using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
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

        //exercise 5 with daytime
        public static void Exercise5()
        {
            Console.WriteLine("Please enter a date");
            string input = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(input);
            int daysUntil = (int)Math.Ceiling(dateTime.Subtract(DateTime.Now).TotalDays);
            Console.WriteLine($"Days until the next SDA classes: {daysUntil}");
        }
        //exercise 6 with regex
        public static void Exercise6()
        {
            Console.WriteLine("Type in a password");
            string input = Console.ReadLine();
            Regex numbers = new Regex("\\d");
            Regex capitalLetters = new Regex("[A-Z]");
            Regex lowercaseLetters = new Regex("[a-z]");
            Regex specials = new Regex("[$#@!%^&*]");
            bool isGoodPassword = true;
            if (numbers.Matches(input).Count < 4) isGoodPassword = false;
            if (capitalLetters.Matches(input).Count < 2) isGoodPassword = false;
            if (lowercaseLetters.Matches(input).Count < 6) isGoodPassword = false;
            if (specials.Matches(input).Count < 1) isGoodPassword = false;
            Console.WriteLine(isGoodPassword ? $"{input} is a good password" : $"{input} is NOT a good password");
        }
        //bonus exercise
        public static void regexExercise()
        {
            Console.WriteLine("Ju lutemi vendosni e-mail-in tuaj: ");
            string input = Console.ReadLine();
            string stregex = @"(@)";
            Regex regex = new Regex(stregex);
            if (regex.IsMatch(input))
            {
                Console.WriteLine("E-mail-i juaj eshte korrekt!");
            }
            else
            {
                Console.WriteLine("E-mail-i juaj nuk eshte korrekt!");
            }
        }
        //homework exercise

        //exercise for a stuttering application
        public static void Exercise7()
        {
            Console.WriteLine("Insert text here");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string word in inputs)
            {
                sb.Append(word);
                sb.Append(word);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
    
