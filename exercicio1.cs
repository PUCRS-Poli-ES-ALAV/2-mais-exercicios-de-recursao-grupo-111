//1. Modele e implemente um método recursivo que calcule o fatorial de um número n passado como parâmetro.

using System;

namespace Program
{
    public class ExFatorial
    {
        public static void Main()
        {
            int n = 5;

            Console.WriteLine("fatorial: " + fatorial(n));
        }

        public static int fatorial(int n)
        {
            if(n < 0) {throw new Exception("Não é possivel calcular o fatorial de um numero negativo.");}

            if(n == 0 || n == 1)
            {
                return 1;
            }
            
            return n * fatorial(n-1);
        }
    }
}