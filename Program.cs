using System;
using System.Globalization;
using System.Collections.Generic;

namespace Heranca
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Quantas figuras voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            List<Figura> lista = new List<Figura>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Figura " + (i+1) + " - Triangulo ou Retangulo (t/r) ? ");
                char escolha = char.Parse(Console.ReadLine());

                if(escolha == 'r')
                {
                    Figura f = Util.lerRetangulo();
                    lista.Add(f);
                } 
                else if(escolha == 't')
                {
                    Console.Write("Lado A: ");
                    double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado B: ");
                    double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado C: ");
                    double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Figura f = new Triangulo(ladoA, ladoB, ladoC);
                    lista.Add(f);
                } else {
                    Console.WriteLine("Opcao invalida!!!");
                }



            }

            Console.WriteLine();
            Console.WriteLine("Area das Figuras:");
            for (int j = 0; j < lista.Count; j++)
            {
                Console.WriteLine("Figura " + (j + 1) + ": " + lista[j].area());
            }

        }
    }
}
