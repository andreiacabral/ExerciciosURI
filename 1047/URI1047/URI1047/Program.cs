using System;
using System.Collections.Generic;
using System.Linq;

namespace URI1047
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entrada;
            int horaInicial, minutoInicial, horaFinal, minutoFinal, resultadoHora, resultadoMinuto;

            entrada = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(entrada[0]);
            minutoInicial = int.Parse(entrada[1]);
            horaFinal = int.Parse(entrada[2]);
            minutoFinal = int.Parse(entrada[3]);


            if (horaInicial == horaFinal && minutoInicial == minutoFinal)
            {
                resultadoHora = 24;
                resultadoMinuto = 0;
            }
            else
            {
                int totalSegundosInicial = ((horaInicial * 60) * 60 + (minutoInicial * 60));
                int totalSegundosFinal = ((horaFinal * 60) * 60 + (minutoFinal * 60));
                int totalSegundos= totalSegundosFinal - totalSegundosInicial;

                resultadoMinuto = totalSegundos / 60;

                resultadoHora = resultadoMinuto / 60;

                if (resultadoHora>0)
                {
                    resultadoMinuto=resultadoMinuto / 60;
                }

                

                

            }

            Console.WriteLine($"O JOGO DUROU {resultadoHora} HORA(S) E {resultadoMinuto} MINUTO(S)");



        }
    }
}