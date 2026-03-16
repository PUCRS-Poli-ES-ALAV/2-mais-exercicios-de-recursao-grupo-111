using System;

namespace Program
{
    public class ExIntervaloSomatorio
    {
        public static void Main()
        {
            int k = 3;
            int j = 5;

            Console.WriteLine("somatorio: " + intervaloSomatorio(k, j));
        }

        public static int intervaloSomatorio (int k, int j)
        {
            if (k == j) {return k;}
                
            if(k < j)
            {
                return k + intervaloSomatorio(k + 1, j);
            }
            else
            {
                return intervaloSomatorio(j,k);
            }
        }
    }
}    
