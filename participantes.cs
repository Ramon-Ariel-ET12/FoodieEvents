namespace FoodieEvents;

public class Participantes
{
    public string nombreCompleto="";
    public string correo="";
    public int telefono;
    public int DNI;
    public int restriccionAlimentaria;
    public Participantes(string nombreCompleto,string correo,int telefono,int DNI,int restriccionAlimentaria){
this.nombreCompleto=nombreCompleto;
this.correo=correo; 
this.telefono=telefono;
this.DNI=DNI;

Validaciones.ValidarParticipantes(restriccionAlimentaria);
this.restriccionAlimentaria=restriccionAlimentaria;
}
}