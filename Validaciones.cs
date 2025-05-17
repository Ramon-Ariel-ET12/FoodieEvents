using System;
namespace FoodieEvents
{
public static class Validaciones
{
        public static void ValidarEvento(int tipoEvento)
        {
            if(tipoEvento > 4)
            {
            throw new ArgumentException("evento no encontrado");
            }
        }
        public static void ValidarParticipantes(int restriccionAlimentaria)
        {
            if(restriccionAlimentaria > 4)
            {
                throw new ArgumentException("No valido");
            }
        }
        public static void ValidarReserva(int estadoReserva)
        {
        if(estadoReserva>3)
        {
        throw new ArgumentException("Esta mal en algo");
        }
        }
}
}