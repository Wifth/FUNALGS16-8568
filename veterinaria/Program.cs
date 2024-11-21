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
int opc = 0;
Boleta b = new Boleta();
Mascota m = new Mascota();
do
{
    Console.Write("**********MENÚ**********\n");
    Console.Write("1.   Registrar Mascota");
    Console.Write("2.   Registrar servicio");
    Console.Write("3.   Registrar Boleta");
    Console.Write("0.   Salir");
    Console.Write("************************");
    Console.Write("Ingrese una opción: ");
    if (opc == 0)
    {
        Environment.Exit(0);
    }
    else if (opc == 1)
    {
        m.ListarMascota();
    }
    else if (opc == 2)
    {

    }
    else if (opc == 3)
    {

    }
} while (opc < 4 && opc > 0);