using System;
using System.Linq;
namespace SumOfConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of elements of Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Integer = new int[n];
            int[] ResInteger = new int[n-1];
            Console.WriteLine("Enter the elements of Array ");
            for(int i = 0; i<n; i++)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                Integer[i] = element;
            }
            // Console.WriteLine("Array is : ");
            // foreach(object e in Integer)
            // {
            //     Console.Write(e + " ");
            // }
            for(int j = 0; j<=n-2;j++)
            {
                int res = Integer[j] + Integer[j+1];
                ResInteger[j] = res;
            }
            Console.WriteLine("Smallest of Sum of consecutive elements of array is:" +ResInteger.Min());
        }
    }
}
