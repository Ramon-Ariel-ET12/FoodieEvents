namespace FoodieEvents;

public class Reserva
{
    public Participantes participante;
    public string inscripcion="";
    public DateTime fecha ;
    public int metodoPago;
    public int estadoReserva;

    public Reserva (Participantes participante,string inscripcion, DateTime fecha,int metodoPago, int estadoReserva){
this.participante = participante;
this.inscripcion=inscripcion;
this.fecha = fecha;
this.metodoPago=metodoPago;
this.estadoReserva=estadoReserva;
    }
}