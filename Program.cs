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

Console.WriteLine("Ingrese una fecha (yyyy-MM-dd):");
DateTime fin = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
Console.WriteLine(fin);

Console.WriteLine("Ingrese la ubicacion donde estara el evento");
string ubicacion =Console.ReadLine();

Eventos eventos = new Eventos(nombre,descripcion,tipoEvento,inicio,fin,ubicacion);
Console.WriteLine("Nombre:" + eventos.nombre);
Console.WriteLine("Descripcion:"+ eventos.descripcion);
Console.WriteLine("El tipo del evento:"+eventos.tipoEvento);
Console.WriteLine("inicio del evento:"+eventos.inicio);
Console.WriteLine("Fin del evento:"+eventos.fin);
Console.WriteLine("Capacidad Maxima de entradas"+eventos.capacidadMaxima);
Console.WriteLine("Precio de la entrada"+eventos.precioEntrada);
Console.WriteLine("La ubicacion es: "+eventos.ubicacion);

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

Participantes participantes=new Participantes(nombreCompleto,correo,telefono,DNI,restriccionAlimentaria);
Console.WriteLine("El nombre Completo:"+participantes.nombreCompleto);
Console.WriteLine("El correo electronico es:"+participantes.correo);
Console.WriteLine("Su numero de telefono es:"+participantes.telefono);
Console.WriteLine("Su DNI es:"+ participantes.DNI);
Console.WriteLine("Tiene restriccion Alimentaria?:"+ participantes.restriccionAlimentaria);

//Chef Organizadores
Console.WriteLine("Ingrese su nombre completo");
string NombreCompleto=Console.ReadLine();

Console.WriteLine("Ingrese su especialidad");
int especialidad=int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu nacionalidad");
int nacionalidad=int.Parse(Console.ReadLine());

Console.WriteLine("Cuantos años de experiencia tienes?");
int cantidadExperiencia=int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu correo");
string Correo =Console.ReadLine();

Console.WriteLine("Ingrese su numero de telefono");
int Telefono=int.Parse(Console.ReadLine());

ChefOrganizadores chefOrganizadores=new ChefOrganizadores(NombreCompleto,especialidad,nacionalidad,cantidadExperiencia,Correo,Telefono);
Console.WriteLine("El nombre Completo:"+chefOrganizadores.NombreCompleto);
Console.WriteLine("Su especialidad:"+chefOrganizadores.especialidad);
Console.WriteLine("Su nacionalidad es:"+chefOrganizadores.nacionalidad);
Console.WriteLine("Años de experiencia:"+chefOrganizadores.cantidadExperiencia);
Console.WriteLine("El correo electronico es:"+chefOrganizadores.Correo);
Console.WriteLine("Su numero de telefono es:"+chefOrganizadores.Telefono);

//Reservas
Console.WriteLine("Ingrese su inscripcion");
string inscripcion=Console.ReadLine();

Console.WriteLine("Indica la fecha del evento");
DateTime fecha=DateTime.ParseExact(Console.ReadLine(),"yyyy-MM-dd", null);

Console.WriteLine("Ingrese su metodo de pago");
int metodoPago=int.Parse(Console.ReadLine());

Console.WriteLine("Indique el estado de la reserva");
int estadoReserva=int.Parse(Console.ReadLine());

