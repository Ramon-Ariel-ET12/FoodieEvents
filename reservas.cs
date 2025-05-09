namespace FoodieEvents;

public class Reserva
{
    public string participante="";
    public string inscripcion="";
    public DateTime fecha ;
    public int metodoPago;
    public int estadoReserva;

    public Reserva (string participante,string inscripcion, DateTime fecha,int metodoPago, int estadoReserva){
this.participante = participante;
this.inscripcion=inscripcion;
this.fecha = fecha;
this.metodoPago=metodoPago;
this.estadoReserva=estadoReserva;
    }
}