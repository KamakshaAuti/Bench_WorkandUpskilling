using System;

namespace PowerOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The value of base: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The value of power: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int res =1; 
            if(b==0)
            {Console.WriteLine(1);}
            if(a==0)
            Console.WriteLine(0);
            else{
            for(int i = 1; i<=b;i++)
            {
                res = res * a;

            }
            Console.WriteLine(a + "^" + b + "= " + res);
            }

        }
    }
}
