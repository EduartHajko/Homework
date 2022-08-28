using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    internal class K_ATask1
    {
        static void Main()

        {
            StringBuilder s = new StringBuilder();
            Console.WriteLine("plese enter a string:");
            string? value1 = Console.ReadLine();
            if (value1 != "stop")
            {
                s.Append(value1);
            }
            else
            {
                Console.WriteLine("cfare keni shkruar me siper: " + s.ToString());
            }

        }

        internal static void solution6()
        {
            throw new NotImplementedException();
        }

        public static void solution2()
        {
            int[] arr = new int[10];
            int i;
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }


        public static void solution3()
        {
            int num, r, sum = 0, t;


            Console.Write("\n\n");
            Console.Write("Check whether a number is a palindrome or not:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
                Console.Write("{0} is a palindrome number.\n", t);
            else
                Console.Write("{0} is not a palindrome number.\n", t);
        }

        public static void solution4()
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

        public static void Solution5()
        {
            Console.WriteLine("Type in text");
            string input = Console.ReadLine();
            DateTime date = DateTime.Parse(input);

            int daysUntil = (int)Math.Ceiling(date.Subtract(DateTime.Now).TotalDays);

            Console.WriteLine($"Days until next SDA classes: {daysUntil}");
        }
        public static void Solution6()
        {
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

   
    
}










