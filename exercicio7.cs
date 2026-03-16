//Modele e implemente um método recursivo que calcule o somatório dos números contidos em um ArrayList de inteiros, passado como parâmetro.

using System;

namespace Program
{
    public class ExArraySomatorio
    {
        public static void Main()
        {
            int [] array = { 5, 3, 2, 7, 1 };

            Console.WriteLine(ArraySomatorio(array));
        }

        public static int ArraySomatorio(int [] array)
        {
            // situações de errp
            if(array == null && array.Length == 0)
            {
                throw new Exception("Erro: sem elementos no array.");
            }

            // casos base

            // recursão

           
        }
    }
}    
