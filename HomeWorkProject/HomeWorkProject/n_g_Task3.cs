

using System.Text;

namespace HomeWorkProject
{
    internal class n_g_Task3
    {




        //        public static void Solution2()
        //        {
        //            Console.WriteLine("Vendosni numrat e array-t ose \"x\" per te dale");
        //            string input = Console.ReadLine();
        //            while (!string.Equals(input, "x", StringComparison.OrdinalIgnoreCase))
        //            {
        //                string[] strings = input.Split(",");
        //                int[] numbers = new int[strings.Length];
        //                for (int i = 0; i < numbers.Length; i++)
        //                {
        //                    numbers[i] = int.Parse(strings[i]);
        //                    Console.WriteLine(i + ",");
        //                }





        //            }
        //        }
        //    }
        //}

        public static void Solution3()
        {
            IDictionary<string, string> userPass = new Dictionary<string, string>();
            userPass.Add("Gimi", "Gimi123");
            userPass.Add("Sandri", "Sandri123");
            userPass.Add("Eni", "Eni123");
            userPass.Add("Tani", "Tani123");
            userPass.Add("Limi", "Limi123");

            Console.WriteLine("fut nje emer");
            string input = Console.ReadLine();

            if (userPass.ContainsKey(input))
            {
                Console.WriteLine("fut password");
                string password = Console.ReadLine();
                foreach (KeyValuePair<string, string> kvp in userPass)
                    if (kvp.Value.Equals(password))
                    {
                        Console.WriteLine("Password is Correct");

                    }
                    else if (!kvp.Value.Equals(password))
                    { 
                        Console.WriteLine("pass not correct");
                    }
                    


            }
            else
            {
                Console.WriteLine("user nuk exist");
            }

            Console.WriteLine("user nuk exist dsgdsgryreyre");


            ;        }
    }
}
