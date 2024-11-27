/*
cree una aplicativo de veterinaria
clases con propiedades: 
    Mascota: nombre, edad, especie
    Servicio: descripcion, precio
    Boleta: codigo, mascota, servicio1, servicio2, total

Use arreglos estáticos de las clases
Debe tener un menu con estas opciones:
- crear, eliminar, listar Servicios
- crear, eliminar, listar Mascotas
- crear, listar Boletas

Para crear boletas debe seleccionar la Mascota y el Servicio de 
sus respectivos arreglos

Divida entre sus integrantes, el lider consolida y los integrantes uno hace lo de servicios y el otro el de mascotas
Debe tener una rama por integrante, el lider debe tener por lo menos 2 ramas: main y dev. debe trabajar y consolidar en dev
*/
using System.ComponentModel.Design;
using veterinaria;
int opc = -1;
Boleta b = new Boleta();
Mascota m = new Mascota();
Servicio s = new Servicio();

Mascota m1 = new Mascota();
Mascota m2 = new Mascota();
Mascota m3 = new Mascota();

do
{
    Console.WriteLine("BIENVENIDO AL MENÚ PRINCIPAL\n");
    Console.WriteLine("************ MENÚ ************\n");
    Console.WriteLine(" 1.   Mascotas");
    Console.WriteLine(" 2.   Servicios");
    Console.WriteLine(" 3.   Boleta");
    Console.WriteLine(" 0.   Salir");
    Console.WriteLine("\n******************************");
    Console.Write("Ingrese una opción: \n");
    opc = int.Parse(Console.ReadLine());

    if (opc == 0) // OPCION: 0 | Salir
    {
        Environment.Exit(0);
    }
    else if (opc == 1) // OPCION: 1 | Mascotas
    {
        Console.Clear();
        Console.WriteLine("\n****** MENÚ DE MASCOTAS ******\n");
        Console.WriteLine("1.   Registrar mascota");
        Console.WriteLine("2.   Eliminar mascota");
        Console.WriteLine("3.   Lista de mascotas");
        Console.WriteLine("0.   Salir");
        Console.WriteLine("\n******************************");
        Console.Write("Ingrese una opción: \n");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 0: Environment.Exit(0); break;
            case 1:
                Console.Clear();
                Console.WriteLine("**** REGISTRO DE MASCOTA ****\n");
                Console.Write("Ingrese el nombre de la 1ra mascota: ");
                m1.nombre = Console.ReadLine();
                Console.Write("Ingrese la edad de su mascota: ");
                m1.edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la especie de su mascota: ");
                m1.especie = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Mascotas registradas correctamente.\n\n");
        break;
            case 2: m.EliminarM(); break;
            case 3:
                Console.Clear();
                Console.WriteLine("**************** Lista de mascotas ****************\n");
                Console.WriteLine($"1. {m1.nombre}, de {m1.edad} año(s) - {m1.especie}");
                Console.WriteLine("\n***************************************************\n\n");
                break;
        }
    }
    else if (opc == 2) // OPCION: 2 | Servicios
    {
        Console.Clear();
        Console.WriteLine("\n ***** MENÚ DE SERVICIOS *****\n");
        Console.WriteLine("1.   Registrar servicio");
        Console.WriteLine("2.   Eliminar servicio");
        Console.WriteLine("3.   Lista de servicios");
        Console.WriteLine("0.   Salir");
        Console.WriteLine("\n******************************");
        Console.Write("Ingrese una opción: \n");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 0: Environment.Exit(0); break;
            case 1: s.CrearS(); break;
            case 2: s.EliminarS(); break;
            case 3: s.ListarServicio(); break;
        }
    }
    else if (opc == 3) // OPCION: 3 | Boleta
    {
        Console.Clear();
        Console.WriteLine("\n******* MENÚ DE BOLETA *******\n");
        Console.WriteLine("1.   Registrar boleta");
        Console.WriteLine("2.   Mostrar boleta");
        Console.WriteLine("0.   Salir");
        Console.WriteLine("\n******************************");
        Console.Write("Ingrese una opción: \n");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 0: Environment.Exit(0); break;
            case 1: b.CrearB(); break;
            case 2: b.ListarBoleta(); break;
        }
    }
} while (opc != 0);