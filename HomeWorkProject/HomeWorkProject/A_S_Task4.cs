//namespace HomeWorkProject
//{
//    public class A_S_Task4
//    {
//        public static void Solution2()
//        {
//            Console.WriteLine("Vendosni numrat e array-t ose \"stop\" per te dale");
//            string input = Console.ReadLine();
//            while (!string.Equals(input, "stop", StringComparison.OrdinalIgnoreCase))
//            {
//                string[] strings = input.Split(",");
//                int[] numbers = new int[strings.Length];
//                for (int i = 0; i < numbers.Length; i++)
//                {
//                    numbers[i] = int.Parse(strings[i]);
//                    Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}


//Task 4
//        {
//            StringBuilder sb = new StringBuilder();
//            Console.WriteLine("Type a word:");
//            string input = Console.ReadLine();
//            if (input.ToLower() != "stop")
//            {
//                sb.Append(input);
//            }
//            else
//            {
//                Console.WriteLine("StringBuilder result" + sb.ToString());
//            }
//        }
//    }
//}


// Usht me dictionary

namespace HomeWorkProject
{
    public class A_S_Task4
    {
        public static void Solution2() // DSH
    {
        Console.WriteLine("Enter the numbers");
string input = Console.ReadLine();
        string[] array = input.Split(" ");
        int[] numbers = new int[array.Length];
        int length = numbers.Length;
for (int i = 0; i<numbers.Length; i++)
{
    numbers[length - 1] = Convert.ToInt32(array[i]);

    length--;
}
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
          
}


public static void Solution1() // Task 9
        {
            Console.WriteLine("Please enter a date:");
                string input = Console.ReadLine();
            DateTime date = DateTime.Parse(input);

            int daysUntil = (int)Math.Ceiling(date.Subtract(DateTime.Now).TotalDays);
            Console.WriteLine($"Days until next SDA classes: {daysUntil}");
        }
        public static void Solution()
        {
            IDictionary<string, string> userPass = new Dictionary<string, string>();
            userPass.Add("Alex", "Alex123");
            userPass.Add("Niko", "Niko123");
            userPass.Add("Enio", "Enio123");
            userPass.Add("Koli", "Koli123");

            Console.WriteLine("Please enter a name to check:");
            string user = Console.ReadLine();
            
            if(userPass.ContainsKey(user))
            {
                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();
                foreach (KeyValuePair<string, string> kvp in userPass)
                    if (kvp.Value.Equals(password))
                    {
                        Console.WriteLine("Passowrd is correct!"); 
                    }
            }
            else
            {
                Console.WriteLine("User does not exist!");
            }
           
        }
    }
}



