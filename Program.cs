using System;
using System.Collections.Generic;

namespace Sorteo
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<string> participantes = new List<string>();  
            Console.WriteLine("Bienvenido al sorteo!!");
            Console.WriteLine("Ingrese a un participante");
            string participante = Console.ReadLine();
            while(!participante.ToLower().Equals("salir"))
            {
                participantes.Add(participante);
                Console.WriteLine("Ingrese a otro participante");
                participante = Console.ReadLine();
            }

            Console.WriteLine("Los participantes del sorteo son:");
            foreach(string itemParticipante in participantes)
            {
                //ver string.Format en MSDN
                Console.WriteLine(string.Format("-{0}", itemParticipante));
            }

            Console.WriteLine("El ganador del sorteo es...");
            int numeroGanador = (new Random()).Next(0, participantes.Count);
            Console.WriteLine(participantes[numeroGanador]);
            Console.ReadKey();
        }
    }
}
