//Modele e implemente um método recursivo para encontrar o maior elemento de um ArrayList.

using System;

namespace Program
{
    public class ExMaiorElemArray
    {
        public static void Main()
        {
            int [] array = { 5, 3, 2, 7, 1 };

            Console.WriteLine("Maior elemento: " + MaiorElementoArray(array));
        }

        public static int MaiorElementoArray(int [] array)
        {
            // situações de erro
            if (array == null || array.Length == 0)
            {
                throw new Exception("Erro: array nulo ou vazio.");
            }

            // casos base

            // se todas posições do array forem iguais? -> retorna qualquer uma ou a primeira ou o que?
            // (falta fazer)

            if (array.Length == 1){ return array[0]; }

            // recursão

            int primeiroElemento = array[0];

            if (primeiroElemento > array[1]) { return primeiroElemento; } //compara, mas e depois?

           // tira o menor elemento (0 ou 1) do array e compara com o proximo do array. 

           
        }
    }
}    
