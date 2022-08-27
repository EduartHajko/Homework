﻿using System;
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

        //ushtrimi 3 me palindrom
        public static void Solution3()
        {
     
            int num, rem, sum = 0, temp;
            //clrscr();    
            Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
            Console.Write("\n Enter a number: ");
            num = Int32.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10; //for getting remainder by dividing with 10    
                num = num / 10; //for getting quotient by dividing with 10    
                sum = sum * 10 + rem;
                /*multiplying the sum with 10 and adding  
                remainder*/
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();

}



        //ushtrimi 3 palindrom reverse
        public static void solution4()
        {
            string value, reversedValue = "";
            Console.Write("Enter a string : ");
            value = Console.ReadLine();
            if (value != null)
            {
                for (int i = value.Length - 1; i >= 0; i--)
                {
                    reversedValue += value[i].ToString();
                }
                if (reversedValue == value)
                {
                    Console.WriteLine("String is a Palindrome String: {0} and Reversed String is: {1}", value, reversedValue);
                }
                else
                {
                    Console.WriteLine("String is not a Palindrome String: {0} and Reversed String: {1}", value, reversedValue);
                }
            }

        }

    }
}
