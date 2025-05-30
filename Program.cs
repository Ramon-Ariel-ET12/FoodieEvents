﻿﻿﻿using FoodieEvents;

//eventos
Console.WriteLine("Ingrese el nombre del evento");
string  nombre =Console.ReadLine();

Console.WriteLine("Ingrese una descripcion del evento");
string descripcion =Console.ReadLine();

Console.WriteLine("Ingrese el tipo de evento(1-cata,2-feria,3-clase,4-cena temática)");
int tipoEvento = int.Parse(Console.ReadLine());
Validaciones.ValidarEvento(tipoEvento);

Console.WriteLine("Ingrese la fecha de inicio el evento(yyyy-MM-dd):");
DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
Console.WriteLine(inicio);

DateTime fin;

    Console.WriteLine("Ingrese la fecha del fin del evento(yyyy-MM-dd):");
    fin = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
    Validaciones.ValidadorFecha(inicio, fin);
    Console.WriteLine(fin);


Console.WriteLine("Ingrese la ubicacion donde estara el evento");
string ubicacion =Console.ReadLine();

Eventos eventos = new Eventos(nombre,descripcion,tipoEvento,inicio,fin,ubicacion);
Console.WriteLine("Nombre:" + eventos.getNombre());
Console.WriteLine("Descripcion:"+ eventos.getdescripcion());
Console.WriteLine("El tipo del evento es:"+eventos.gettipoEvento());
Console.WriteLine("inicio del evento:"+eventos.getinicio());
Console.WriteLine("Fin del evento:"+eventos.getFin());
Console.WriteLine("Capacidad Maxima de entradas"+eventos.getcapacidadMaxima());
Console.WriteLine("Precio de la entrada"+eventos.getprecioEntrada());
Console.WriteLine("La ubicacion es: "+eventos.getubicacion());

//Participantes
Console.WriteLine("Ingrese su nombre completo de participante");
string  nombreCompleto=Console.ReadLine();

Console.WriteLine("Ingrese su correo del participante");
string correo=Console.ReadLine();

Console.WriteLine("Ingrese su numero de telefono de participante");
int telefono=int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su DNI");
int DNI=int.Parse(Console.ReadLine());

Console.WriteLine("¿Tiene una restriccion alimentaria?");
int restriccionAlimentaria=int.Parse(Console.ReadLine());
Validaciones.ValidarParticipantes(restriccionAlimentaria);

Participantes participantes=new Participantes(nombreCompleto,correo,telefono,DNI,restriccionAlimentaria);
Console.WriteLine("El nombre Completo:"+participantes.getnombreCompleto());
Console.WriteLine("El correo electronico es:"+participantes.getcorreo());
Console.WriteLine("Su numero de telefono es:"+participantes.gettelefono());
Console.WriteLine("Su DNI es:"+ participantes.getDNI());
Console.WriteLine("Tiene restriccion Alimentaria?:"+ participantes.getrestriccionAlimentaria());

//Chef Organizadores
Console.WriteLine("Ingrese nombre completo  del chef/Organizador");
string NombreCompleto=Console.ReadLine();

Console.WriteLine("Ingrese su especialidad");
int especialidad=int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu nacionalidad");
int nacionalidad=int.Parse(Console.ReadLine());

Console.WriteLine("Cuantos años de experiencia tienes?");
int cantidadExperiencia=int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa correo del chef/Organizador");
string Correo =Console.ReadLine();

int Telefono=int.Parse(Console.ReadLine());

ChefOrganizadores chefOrganizadores=new ChefOrganizadores(NombreCompleto,especialidad,nacionalidad,cantidadExperiencia,Correo,Telefono);
Console.WriteLine("El nombre Completo:"+chefOrganizadores.getNombreCompleto());
Console.WriteLine("Su especialidad:"+chefOrganizadores.getespecialidad());
Console.WriteLine("Su nacionalidad es:"+chefOrganizadores.getNacionalidad());
Console.WriteLine("Años de experiencia:"+chefOrganizadores.getcantidadExperiencia());
Console.WriteLine("El correo electronico es:"+chefOrganizadores.GetCorreo());
Console.WriteLine("Su numero de telefono es:"+chefOrganizadores.GetTelefono());

//Reservas
Console.WriteLine("Ingrese su inscripcion");
string inscripcion=Console.ReadLine();

Console.WriteLine("Indica la fecha del evento");
DateTime fecha=DateTime.ParseExact(Console.ReadLine(),"yyyy-MM-dd", null);

Console.WriteLine("Ingrese su metodo de pago");
int metodoPago=int.Parse(Console.ReadLine());

Console.WriteLine("Indique el estado de la reserva");
short estadoReserva=short.Parse(Console.ReadLine());
Validaciones.ValidarReserva(estadoReserva);

Reserva reserva=new Reserva(participantes,inscripcion, fecha, metodoPago, estadoReserva);
Console.WriteLine(" su inscripcion:" + reserva.getinscripcion());
Console.WriteLine(" la fecha del evento :" + reserva.getfecha());
Console.WriteLine(" el metodo de pago:" + reserva.getmetodoPago());
Console.WriteLine("el estado de la reserva:" + reserva.getestadoReserva());