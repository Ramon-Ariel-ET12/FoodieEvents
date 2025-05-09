namespace FoodieEvents;

public class Eventos
{
    public string nombre="";
    public string descripcion="";
    public int tipoEvento ;
    public DateTime inicio;
    public DateTime fin;
    public int capacidadMaxima = 100;
    public int precioEntrada = 35;
    public string ubicacion="";

    public Eventos(string? nombre, string? descripcion, int tipoEvento, DateTime inicio, DateTime fin, string? ubicacion)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.tipoEvento = tipoEvento;
        this.inicio = inicio;
        this.fin = fin;
        this.ubicacion = ubicacion;
    }

    public Eventos(string nombre, string descripcion,int tipoEvento,DateTime inicio,DateTime fin,int capacidadMaxima,int precioEntrada,string ubicacion){
this.nombre = nombre;
this.descripcion = descripcion;
this.tipoEvento = tipoEvento;
this.inicio = inicio;
this.fin = fin;
this.capacidadMaxima = capacidadMaxima;
this.precioEntrada = precioEntrada;
this.ubicacion = ubicacion;
}
}
