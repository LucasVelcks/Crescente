using System;

namespace Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, menor, meio, maior;

            Console.WriteLine("Digite 3 numeros na mesma linha:");

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            Console.WriteLine();

            if (x < y && x < z)
            {
                menor = x;
                if (y < z)
                {
                    meio = y;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = y;
                }
            }
            else if (y < x && y < z)
            {
                menor = y;
                if (x < z)
                {
                    meio = x;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = x;
                }
            }
            else
            {
                menor = z;
                if (x < y)
                {
                    meio = x;
                    maior = y;
                }
                else
                {
                    meio = y;
                    maior = x;
                }
            }

            Console.WriteLine("Numeros: ");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine();
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Meio: " + meio);
            Console.WriteLine("Maior: " + maior);
        }
    }
}
