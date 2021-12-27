using System;
using System.Collections.Generic;
using System.Linq;

namespace URI1131
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int golsInter, golsGremio, grenais = 0,empate=0, repete = 1, vitoriasInter=0, vitoriasGremio=0; ;
            string[] entradaGols;

            while (repete == 1)
            {
                grenais++;
                entradaGols = Console.ReadLine().Split(' ');

                golsInter = int.Parse(entradaGols[0]);
                golsGremio = int.Parse(entradaGols[1]);

                if (golsGremio>golsInter)
                {
                    vitoriasGremio++;
                }
                else if (golsGremio < golsInter)
                {
                    vitoriasInter++;
                }
                else
                {
                    empate++; 
                }


                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                repete = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(grenais+ " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("empate:" + empate);

            if (vitoriasGremio>vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (vitoriasGremio < vitoriasInter)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
         


        }
    }
}