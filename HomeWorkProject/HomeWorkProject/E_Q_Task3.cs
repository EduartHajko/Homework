using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProjectTask3
{
    public class E_Q_Task3
    {
        public static void SolutionTask3()
        {
            try
            {
                string input;
                StringBuilder result = new StringBuilder();

                Console.WriteLine("Enter a word");
                do
                {
                    input = Console.ReadLine();

                    new StringBuilder(input);
                    result.Append(input + " ");


                } while (input.Trim().ToLower() != "stop");

                Console.WriteLine(result);
            }
            catch(Exception)
            { 
                throw;
            }
        }
        public static void SolutionExercise()
        {
            try
            {
                Console.WriteLine("Please enter the numbers");
                string input = Console.ReadLine();

                string[] array = input.Split(",");
                int[] numbers = new int[array.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(array[i]);
                }
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            catch(Exception)
            {
                throw;
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
        public static void TaskD()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Geri", "123$");
            dict.Add("Mikel", "345&");
            dict.Add("Kridens", "2222");
            dict.Add("Koli", "2000");

            foreach (KeyValuePair<string, string> dn in dict)

            {
                if (dict.ContainsKey("Geri"))
                {
                    Console.WriteLine(dn.Key);
                }
            }
        }
    }
}
