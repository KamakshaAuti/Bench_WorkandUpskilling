using System;

namespace NegativePower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The value of base: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The value of power: ");
            int b = Convert.ToInt32(Console.ReadLine());
            float res=1;
            float c = 1;
            for(int i=b; i<0; i++)
            {
                c = c*a;
                res = 1/c;
            }
            Console.WriteLine(res);
        }
    }
}
