
using HomeWorkProject;

public class SDA
{
    public static void Main()
    {
        //Ky kodi therret zgjidhjen nga klasa solution task 1
        //Task1.Solution();
        //Homework1.Solution();
        //D_SH_Task3.SolutionTask3();
       // D_SH_Task3.Solution4();
        Console.WriteLine("Enter the numbers");
        string input = Console.ReadLine();
        string[] array = input.Split(" ");
        int[] numbers = new int[array.Length];
        int length = numbers.Length;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[length - 1] = Convert.ToInt32(array[i]);
            //numbers[i] = Convert.ToInt32(array[i]);
            length--;
        }
        // for(int i = 0; i < numbers.Length; i++)
        //{
        //}
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

    }
}