//Modele e implemente um método recursivo que recebe um inteiro zero ou positivo e retorna um String com o número em binário.

using System;

namespace program
{
    public class ExConversaoBase2
    {
        public static void Main()
        {
            int n = 5;

            Console.WriteLine(ConvBase2(n));
        }

        public static string ConvBase2(int n)
        {
            if (n < 0)
            {
                throw new Exception("Erro!");
            }
            else if(n == 0){ return "0"; }
            else if(n == 1){ return "1"; }

            return ConvBase2(n / 2) + (n % 2);
        }
    }
}




