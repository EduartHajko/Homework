using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class Task1
    {
        public static void Solution()
        {
            try
            {
                Console.WriteLine("Type in circle diameter:");
                string input = Console.ReadLine();
                double diameter = double.Parse(input);
                double perimeter = 2 * Math.PI * diameter;
                Console.WriteLine($"Circle perimeter is {perimeter}");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
