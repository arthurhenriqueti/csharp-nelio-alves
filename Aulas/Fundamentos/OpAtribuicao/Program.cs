using System;

namespace OpAtribuicao
{
    class Program
    {
        public static void Main(string[] args)
        {
            int valor = 0;
            Console.WriteLine("Operadores de atribuição:");
            Console.WriteLine(valor = 10);
            Console.WriteLine(valor += 10);
            Console.WriteLine(valor -= 10);
            Console.WriteLine(valor *= 10);
            Console.WriteLine(valor /= 10);
            Console.WriteLine(valor %= 10);
        }
    }
}