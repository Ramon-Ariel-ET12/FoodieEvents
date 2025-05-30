using System;
namespace FoodieEvents
{
    public static class Validaciones
    {
        public static void ValidarEvento(int tipoEvento)
        {
            if (tipoEvento > 4)
            {
                throw new ArgumentException("evento no encontrado");
            }
        }
        public static void ValidarParticipantes(int restriccionAlimentaria)
        {
            if (restriccionAlimentaria > 4)
            {
                throw new ArgumentException("No valido");
            }
        }
        public static void ValidarReserva(int estadoReserva)
        {
            if (estadoReserva > 3)
            {
                throw new ArgumentException("Esta mal en algo");
            }
        }


        public static void ValidadorFecha(DateTime inicio, DateTime fin)
        {
            if (fin < inicio)
            {
                throw new ArgumentException("La fecha de fin no puede ser menor a la fecha de inicio");
            }
        }

        public static void ValidarOpcion(int opcion, int minimo, int maximo)
        {
            if (opcion < minimo || opcion > maximo)
            {
                throw new ArgumentException($"La opción debe estar entre {minimo} y {maximo}");
            }

        }

    }
}