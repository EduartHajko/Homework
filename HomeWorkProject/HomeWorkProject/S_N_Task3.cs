using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class S_N_Task3
    {
        //Ushtrimi1
        public static void Solution1()
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
            catch (Exception)
            {
                throw;
            }
        }
        //Ushtrimi2
        public static void Solution2()
        {
            try
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                string[] array = input.Split(",");
                int[] numbers = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(array[i]);
                }
                {
                    foreach (int number in numbers)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //ushtrimi3
        public static void Solution3()
        {
            Console.Write("Enter a Number To Check Palindrome : ");
            int number = int.Parse(Console.ReadLine());
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                remineder = number % 10;
                sum = (sum * 10) + remineder;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            Console.ReadKey();
        }
        //Ushtrimi4
        public static void Solution4()
        {
            Console.Write("Enter a name to Check Palindrome : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
            Console.ReadKey();
        }
        //ushtrimi 5
        public static void Solution5()
        {
            string input = Console.ReadLine();
            IDictionary<string, string> usernames = new Dictionary<string, string>();
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
        //ushtimi6
        public static void Solution6()
        {
            Console.WriteLine("JU lutem vendosni Daten");
            string input = Console.ReadLine();
            DateTime date = DateTime.Parse(input);

            int daysUntil = (int)Math.Ceiling(date.Subtract(DateTime.Now).TotalDays);

            Console.WriteLine($"Ditet deri ne klasen e rradhes ne SDA jane: {daysUntil}");
        }
        public static void Solution7()
        {
            try
            {
                Console.WriteLine("PLease insert the date of the next course in format(MM/dd/yyyy): \n");
                string nextCourseDate = Console.ReadLine();
                DateTime enteredDate = DateTime.Parse(nextCourseDate);
                Console.WriteLine("You date of the next lesson in SDA is: {0}", enteredDate);
                DateTime todayDate = DateTime.Today;
                Console.WriteLine("The current day is: {0}", todayDate.ToString("MM/dd/yyyy"));
                int daysRemaining = (enteredDate.Date - todayDate).Days;
                Console.WriteLine("The days until the next course date are: {0}.", daysRemaining);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void Solution9()
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
    }
}