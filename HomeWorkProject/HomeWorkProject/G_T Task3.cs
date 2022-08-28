using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    internal class G_TTask3
    {
        static void Main()
        {

            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Please enter a string: ");
            string? value1 = Console.ReadLine();

            if (value1 != "stop")
            {
                sb.AppendLine(value1);
            }
            else
            {
                Console.WriteLine("Cfare kemi shkruar me siper: " + sb.ToString());
            }





            //Ushtimi 2
            static void Solution2()

            {
                int[] arr = new int[10];
                int i;
                Console.Write("\n\nRead and Print elements of an array:\n");
                Console.Write("-----------------------------------------\n");

                Console.Write("Input 10 elements in the array :\n");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());// i trwegon poz ne te cilin ti do te vendosesh nje numer
                }

                Console.Write("\nElements in array are: ");
                for (i = 0; i < 10; i++)// i++ e inkrementon edhe me 1
                {
                    Console.Write("{0}  ", arr[i]);
                }
                Console.Write("\n");
            }



            //Ushtrimi 3

            {
                static void Main(string[] args)
                {
                    int n, r, sum = 0, temp;
                    Console.Write("Enter the Number: ");
                    n = int.Parse(Console.ReadLine());
                    temp = n;
                    while (n > 0)
                    {
                        r = n % 10;// for getting a remminder by deviding with 10
                        sum = (sum * 10) + r;
                        n = n / 10;// for getting 
                    }
                    if (temp == sum)
                        Console.Write("Number is Palindrome.");
                    else
                        Console.Write("Number is not Palindrome");
                }

            }

        }



        //Ushtrimi Detyre Shtepie

        
                static void Main(string[] args)
        {
        int i, n;
        int[] a = new int[100];

        Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
        Console.Write("------------------------------------------------------------------------\n");
   
        Console.Write("Input the number of elements to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());    
   
   
        Console.Write("Input {0} number of elements in the array :\n",n);
         for(i=0;i<n;i++)
            {
	          Console.Write("element - {0} : ",i);
	          a[i] = Convert.ToInt32(Console.ReadLine()); 
	        }

         Console.Write("\nThe values store into the array are : \n");
         for(i=0;i<n;i++)
          {
	        Console.Write("{0}  ",a[i]);
	      }

          Console.Write("\n\nThe values store into the array in reverse are :\n");
          for (i = n - 1; i >= 0; i--)
           {
             Console.Write("{0} ", a[i]);
           }
            Console.Write("\n\n");
           } 



        //Ushrimi 1 , Dita 2

        static void Solution3()
        {
            string input = Console.ReadLine();
            IDictionary<string, string> numberNames = new Dictionary<string, string>();
            numberNames.Add("edi","123!");// adding key/value using Add() method
            numberNames.Add("sami","555$");
            numberNames.Add("Emma","111!");
            numberNames.Add("Anna","232?");
           

            foreach (KeyValuePair<string, string> kvp in numberNames)
            {
                if(kvp.Key.Equals(input))
                {
                    Console.WriteLine("Username is correct");
                    string pass = Console.ReadLine();

                    foreach(KeyValuePair<string, string> kvp2 in numberNames)
                    {
                        if(!kvp.Value.Equals(pass))
                        {
                            Console.WriteLine(" Password is correct :) ");
                            break;
                        }
                    }
                } 
            }
                
        }
          } 
        }
    



