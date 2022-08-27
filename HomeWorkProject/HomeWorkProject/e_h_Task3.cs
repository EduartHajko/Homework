using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
  

    public class e_h_Task3
    {
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
    }
}
