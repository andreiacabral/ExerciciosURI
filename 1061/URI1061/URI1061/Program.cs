using System;
using Microsoft.VisualBasic;

namespace URI1061
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diaInicio, horarioInicio, diaFim, horarioFim;

            int diaComeco, diaTermino,horaInicio,minutoInicio,segundoInicio,horaFim,minutoFim,segundoFim;

            int totalDias,totalHoras,totalMinutos,totalSegundos;

            diaInicio = (Console.ReadLine().Split(' '));
            horarioInicio = (Console.ReadLine().Split(' '));
            diaFim = (Console.ReadLine().Split(' '));
            horarioFim = (Console.ReadLine().Split(' '));

            diaComeco=int.Parse(diaInicio[1]);
            diaTermino = int.Parse(diaFim[1]);

            horaInicio = int.Parse(horarioInicio[0]);
            minutoInicio = int.Parse(horarioInicio[2]);
            segundoInicio = int.Parse(horarioInicio[4]);

            horaFim = int.Parse(horarioFim[0]);
            minutoFim = int.Parse(horarioFim[2]);
            segundoFim = int.Parse(horarioFim[4]);

            totalDias = diaTermino - diaComeco;

            if (horaFim<horaInicio)
            {
               totalHoras = (horaFim - horaInicio) + 24;
            }
            else
            {
                totalHoras = (horaFim - horaInicio);
            }
            if (minutoFim < minutoInicio)
            {
                totalMinutos = (minutoFim - minutoInicio) + 60;
            }
            else
            {
                totalMinutos = (minutoFim - minutoInicio);
            }
            if (segundoFim < segundoInicio)
            {
                totalSegundos = (segundoFim - segundoInicio) + 60;
            }
            else
            {
                totalSegundos = (segundoFim - segundoInicio);
            }

            Console.WriteLine(totalDias + " dia(s)");
            Console.WriteLine(totalHoras + " hora(s)");
            Console.WriteLine(totalMinutos + " minuto(s)");
            Console.WriteLine(totalSegundos + " segundo(s)");



        }
    }
}
