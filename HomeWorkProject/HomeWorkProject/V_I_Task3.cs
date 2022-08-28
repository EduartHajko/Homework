using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HomeWorkProject
{
    public class V_I_Task3
    { 
        /*
        public static void getValue()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Ju lutemi fusni fjalet: ");
            string s=Console.ReadLine();

            if (s.ToLower() != "stop") 
            {
                sb.Append(s+" ");
            }
            else
            {
                
            }
            Console.WriteLine("String builder perfundimatare: " + sb.ToString());
            //per shume vlera perdor ciklin for each
        }

        //ushtrimi 2:Write a C# program to store elements in an array and print it.
        public static void solution()
        {
            int[] table;
            Console.WriteLine("Jepni madhesine e arrayt: ");
            string? size = Console.ReadLine();
            int truesize;
            bool kovertohet = Int32.TryParse(size, out truesize);

            if (!kovertohet)
            {
                Console.WriteLine("Nuk mund te kovertohet.");
                return;
            }
            table = new int[truesize];

            Console.WriteLine("Jepni numrat: ");
            string? numraString = Console.ReadLine();
            bool aKonvertohet = Int32.TryParse(numraString, out int number);

            if (!aKonvertohet)
            {
                Console.WriteLine("Nuk mund te kovertohet.");
                return;
            }
            
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = number;
            }

            foreach(int i in table)
            {
                Console.WriteLine("Tabela eshte: " + table[number]);
            }
        }
        */
        //Ushtrimi 3: Write a number and check whether it is a palindrome

        public static void palindrome()
        {
            Console.WriteLine("Jepni nje numer: ");
            string? input = Console.ReadLine();
            bool uKonvertua = Int32.TryParse(input, out int number);
            int anasjellti = number;

            if (!uKonvertua)
            {
                Console.WriteLine("Inputi eshte i gabuar!");
                return ;
            }
            int mbetja;
            int shuma = 0;

            while(number > 0)
            {
                mbetja = number % 10;
                number /= 10;
                shuma = shuma * 10 + mbetja;
            }

            if (anasjellti == shuma)
            {
                Console.WriteLine("Numri eshte palindrome.");
            }
            else
            {
                Console.WriteLine("Numri nuk eshte palindrome.");
            }
        }

        //Detyre shtepie: Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
        //mos perdorni linq commands

        //public static void reverse()
        //{
        //    Console.WriteLine("Jepni madhesine e tables: ");
        //    int n=Convert.ToInt32(Console.ReadLine());

        //    int[] a = new int[n];

        //    for(int i=0; i<n; i++)
        //    {
        //        a[i] = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Vlerat e vendosura ne tabele jane: ", a[i]);
        //    }

        //    for(int i=n-1; i>=0; i--)
        //    {
        //        Console.WriteLine("Tabela ne rendin e kundert: ", a[i]);
        //    }
            
        //}

        //Ushtrim shto nje username nga console dhe verifiko nqs eshte ne dictionary ose jo(e njejte me passwordin)

        public static void verifikoTeDhenat()
        {
            string input = Console.ReadLine();
            IDictionary<string, string> smallDictionary = new Dictionary<string, string>();
            smallDictionary.Add("vanesa", "hello123");
            smallDictionary.Add("anduela", "nice456");
            smallDictionary.Add("charles", "monaco16");

            foreach (KeyValuePair<string, string> pair in smallDictionary)
            {
                if (pair.Key.Equals(input))
                {
                    Console.WriteLine("Username is incorrect!");
                    string pass = Console.ReadLine();
                    foreach (KeyValuePair<string, string> pair2 in smallDictionary)
                    {
                        if (pair2.Value.Equals(pass))
                        {
                            Console.WriteLine("Username is incorrect!");
                            break;
                        }
                    }
                }
            }

        }
    }
}
