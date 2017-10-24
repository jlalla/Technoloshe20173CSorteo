using System;

namespace Sorteo
{
    public class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        public string NombreCompleto()
        {
            return string.Format("{0} {1}", this.Nombre, this.Apellido);
        }

        public int CalcularEdad()
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - this.FechaDeNacimiento.Year;

            if (ahora.Month < FechaDeNacimiento.Month
                || (ahora.Month == FechaDeNacimiento.Month
                    && ahora.Day < FechaDeNacimiento.Day))
                edad--;

            return edad;
        }
    }
}