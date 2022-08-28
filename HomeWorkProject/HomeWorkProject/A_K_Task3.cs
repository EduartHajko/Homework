using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Dictionary<string, string> userData = new Dictionary<string, string>();
            userData.Add("Armir", "armir2022");
            userData.Add("Reni", "reni2022");
            userData.Add("Bledi", "bledi2022");

            Console.WriteLine("Input name: ");
            String input = Console.ReadLine();

            foreach (KeyValuePair<string, string> kvp in userData)
            {
                if (kvp.Key.Equals(input))
                {
                    Console.WriteLine("Username is correct");
                    string pass = Console.ReadLine();
                    foreach (KeyValuePair<string, string> kvn in userData)
                    {
                        if (kvn.Value.Equals(pass))
                        {
                            Console.WriteLine("Password is Correct");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Password is INCorrect");
                        }
                    }
                }
            }
        }

        public static void Solution5()
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

        public static void Solution6()
        {
            Console.WriteLine("Please insert the email address of the user: ");
            string email = Console.ReadLine();

            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (!isEmail)
            {
                Console.WriteLine("Email address not valid!");
            }
            else
            {
                Console.WriteLine("The address entered is a valid email");
            }
        }
    }
}
