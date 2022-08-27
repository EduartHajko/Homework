using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
  

    public class e_h_Task3
    {
        //ushtrimi 1
        public static void Solution()
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
                Console.WriteLine("rezultati i string builderit" + sb.ToString());
            }

        }


        //ushtrimi 2 
        public static void Solution2()
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


    }
}
