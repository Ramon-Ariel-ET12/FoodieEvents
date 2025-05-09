using FoodieEvents;

//eventos
Console.WriteLine("Ingrese el nombre del evento");
string  nombre =Console.ReadLine();

Console.WriteLine("Ingrese una descripcion del evento");
string descripcion =Console.ReadLine();

Console.WriteLine("Ingrese el tipo de evento");
int tipoEvento=int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese una fecha (yyyy-MM-dd):");
DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
Console.WriteLine(inicio);

//Participantes
Console.WriteLine("Ingrese su nombre completo");
string nombreCompleto=Console.ReadLine();

Console.WriteLine("Ingrese su correo");
string correo=Console.ReadLine();

Console.WriteLine("Ingrese su numero de telefono");
int telefono=int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su DNI");
int DNI=int.Parse(Console.ReadLine());

Console.WriteLine("¿Tiene una restriccion alimentaria?");
int restriccionAlimentaria=int.Parse(Console.ReadLine());

