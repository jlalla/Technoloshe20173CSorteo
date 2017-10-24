using System;
using System.Collections.Generic;

namespace Sorteo
{
    class Program
    {
        static void Main(string[] args)
        {   
            //ahora tenemos lista de personas (es un tipo nuevo)!
            List<Persona> listaParticipantes = new List<Persona>();              
            Console.WriteLine("Bienvenido al sorteo!!");
            Console.Write("Ingrese a un participante: ");
            string participante = Console.ReadLine();
            while(!participante.ToLower().Equals("salir"))
            {
                //creamos una instancia de la clase persona
                //(creamos una persona)
                Persona nuevaPersona = new Persona();
                nuevaPersona.Nombre = participante;
                listaParticipantes.Add(nuevaPersona);
                Console.Write("Ingrese a otro participante: ");
                participante = Console.ReadLine();
            }

            Console.WriteLine("Los participantes del sorteo son:");
            foreach(Persona persona in listaParticipantes)
            {
                //ver string.Format en MSDN
                Console.WriteLine(string.Format("-{0}", persona.Nombre));
            }

            Console.WriteLine("La persona ganadora del sorteo es...");
            int numeroGanador = (new Random()).Next(0, listaParticipantes.Count);
            Console.WriteLine(listaParticipantes[numeroGanador].Nombre);
            Console.ReadKey();
        }
    }
}
