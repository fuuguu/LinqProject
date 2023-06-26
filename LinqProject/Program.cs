using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int[] arr = new int[20];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(1, 10);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        int countEven = arr.Count(x => x % 2 == 0);
        int countOdd = arr.Count(x => x % 2 != 0);



        if (countEven > countOdd)
        {
            Console.WriteLine("В массиве больше четных чисел");
        }
        else if (countEven < countOdd)
        {
            Console.WriteLine("В массиве больше нечетных чисел");
        }
        else
        {
            Console.WriteLine("В массиве одинаковое количество четных и нечетных чисел");
        }
    }
}