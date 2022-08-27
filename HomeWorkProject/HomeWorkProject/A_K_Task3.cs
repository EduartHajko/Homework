using System;
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
            int[] arr = new int[10];
            int i;

            Console.WriteLine("Input 10 elements in the array :\n");

            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nElements in array are: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}  ", arr[i]);
            }
            Console.WriteLine("\n");
        }

    }
}
