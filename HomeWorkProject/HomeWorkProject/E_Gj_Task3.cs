using System.Text;
namespace HomeWorkProject
{
    internal class E_Gj_Task3
    {
        //    public static void Solution()
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        Console.WriteLine("Type a word:");
        //        string input = Console.ReadLine();
        //        if (input.ToLower() != "stop")
        //        {
        //            sb.Append(input);
        //        }
        //        else
        //        {
        //            Console.WriteLine("StringBuilder result" + sb.ToString());
        //        }
        //    }
        //}
        //}


        //    public static void Solution2()
        //    {
        //        Console.WriteLine("Vendosni numrat e array-t ose \"x\" per te dale");
        //        string input = Console.ReadLine();
        //        while (!string.Equals(input, "x", StringComparison.OrdinalIgnoreCase))
        //        {
        //            string[] strings = input.Split(",");
        //            int[] numbers = new int[strings.Length];
        //            for (int i = 0; i < numbers.Length; i++)
        //            {
        //                numbers[i] = int.Parse(strings[i]);
        //                Console.WriteLine(i + ",");
        //            }

        //        }
        //    }
        //}

        //        public static void Solution3()
        //        {
        //            IDictionary<string, string> accounts = new Dictionary<string, string>();
        //            accounts.Add("Maksi", "lushnje123");
        //            accounts.Add("Fredi", "fier123");
        //            accounts.Add("Latifi", "korce123");
        //            accounts.Add("Myrto", "berat123");

        //            Console.WriteLine("Vendos nje username");
        //            string input = Console.ReadLine();

        //            if(accounts.ContainsKey(input))
        //            {
        //                Console.WriteLine("Vendos password");
        //                string password = Console.ReadLine();
        //                foreach (KeyValuePair<string, string> kvp in accounts)
        //                    if (kvp.Value.Equals(password))
        //                        {
        //                        Console.WriteLine("Passowrd is correct");

        //                    }
        //                else if (!kvp.Value.Equals(password))
        //                    {
        //                        Console.WriteLine("Password is incorrect");
        //                    }






        //            }
        //            else
        //            {
        //                Console.WriteLine("User nuk egziston");
        //            }



        //        }


        //    }
        //}


        //    public static void Solution4()
        //    {
        //        Console.WriteLine("Type in text");
        //        string input = Console.ReadLine();
        //        DateTime date = DateTime.Parse(input);
        //        int daysUntil = (int)Math.Ceiling(date.Subtract(DateTime.Now).TotalDays);

        //        Console.WriteLine($"Days until next SDA classes: {daysUntil}");

        //    }

        //}


        public static void Solution5()
        {
            Console.WriteLine("Type in text");
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