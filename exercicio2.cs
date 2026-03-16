using System;

namespace Program
{
    public class ExSomatorio
    {
        public static void Main()
        {
            int n = 5;

            Console.WriteLine("somatorio: " + somatorio(n));
        }

        public static int somatorio(int n)
        {
            //situações de erro: N/A
            //situação de parada(base): n == 0 -> 0
            if (n == 0) { return 0;}

            if (n > 0)
            {
                return n + somatorio(n-1);   
            }
            else
            { 
                return n + somatorio(n + 1);  
            }
        }
    }
}