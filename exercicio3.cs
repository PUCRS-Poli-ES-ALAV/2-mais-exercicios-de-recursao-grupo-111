using System;

namespace Program
{
    public class ExFibonacci
    {
        public static void Main()
        {
            int n = 3;

            Console.WriteLine("fibonacci: " + fibo(n));
        }

        public static int fibo(int n)
        {
            if(n <= 0) {throw new Exception("exception!");} 

            if(n == 1 || n == 2) 
            {
                return 1;
            }

            return fibo(n-1) + fibo(n-2);
        }
    }
}    
