using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HomeWorkProject

{

    public class AGJ_task
    {
        public static void Solution()
        {
            //string input = Console.ReadLine();
            //IDictionary<string, string> usernames = new Dictionary<string, string>();
            //usernames.Add("Serin", "1234");
            //usernames.Add("Rusi", "123456");
            //usernames.Add("Oli", "12345678");
            //foreach (KeyValuePair<string, string> kvp in usernames)
            //{
            //    if (kvp.Key.Equals(input))
            //    {
            //        Console.WriteLine("Username is correct");
            //        string pass = Console.ReadLine();
            //        foreach (KeyValuePair<string, string> kvn in usernames)
            //        {
            //            if (kvn.Value.Equals(pass))
            //            {
            //                Console.WriteLine("Password is Correct");
            //                break;
            //            }
            //        }
            //    }
            //}
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
            //        }
            //    }
            //}




            //int[] vektor = new int[10];
            //for (int i = 0; i < vektor.Length; i++)
            //{
            //    vektor[i] = int.Parse(Console.ReadLine());

            //    Console.WriteLine(vektor[i]);

            //}
            //}
            //}


            //Detyra e shtepise
            //int[] num = { 22, 50, 11, 2, 49 };
            //Array.Reverse(num);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write(num[i] + " ");
            //}



            //DateTime CurrentDate = DateTime.Now;


            //Console.WriteLine("The current date is: " + CurrentDate);


            //Console.WriteLine("Put the next date ");


            //string fieldValue = Console.ReadLine();

            //CultureInfo ItalianDate = new CultureInfo("it-IT", false);                 //shtova using globalisation

            //string[] formats = { "MM/dd/yyyy" };


            //DateTime dateValue;
            //if (DateTime.TryParseExact(fieldValue, formats, ItalianDate, DateTimeStyles.AllowWhiteSpaces, out dateValue)) ;

            //int daysUntil = (int)Math.Ceiling(dateValue.Subtract(CurrentDate).TotalDays);


            //Console.WriteLine("days until next course  " +  daysUntil);


            Console.WriteLine("Shkruaj nje fjali : ");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            StringBuilder sb = new StringBuilder();

            foreach (string word in inputs)
            {
                sb.Append($"{word} ");
                sb.Append($"{word} ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}







