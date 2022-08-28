using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    internal class b_p_Task3
    {
        //ushtrimi 1
        //        Console.WriteLine("Enter string: ");
        //        string? input = Console.ReadLine();

        //ushtrimi 2

        //ushtrimi 3 - te shikojme nese nje numer eshte palindrome

        //public static void Solution3()
        //{
        //    int num, rem, sum = 0, temp;
        //    //clrscr();    
        //    Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
        //    Console.Write("\n Enter a number: ");
        //    num = Convert.ToInt32(Console.ReadLine());
        //    temp = num;
        //    while (num > 0)
        //    {
        //        rem = num % 10; //for getting remainder by dividing with 10    
        //        num = num / 10; //for getting quotient by dividing with 10    
        //        sum = sum * 10 + rem;
        //        /*multiplying the sum with 10 and adding  
        //        remainder*/
        //    }
        //    Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
        //    if (temp == sum) //checking whether the reversed number is equal to entered number    
        //    {
        //        Console.WriteLine("\n Number is Palindrome \n\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\n Number is not a palindrome \n\n");
        //    }
        //    Console.ReadLine();
        //}

        //28-08-2022
        //Ushtrimi 1 - Dictionary

        public static void Dictionary()
        {
            IDictionary<string, string> userPass = new Dictionary<string, string>();
            userPass.Add("Bledi", "1234"); //adding a key/value using the Add() method
            userPass.Add("Amir", "5678");
            userPass.Add("Reni", "98174");

            foreach (KeyValuePair<string, string> kvp in userPass)
                if
                {
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                }
                
        }

    }
}



