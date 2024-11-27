using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Mascota
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string especie { get; set; }
        public void CrearM()
        {
            Console.Clear();
            
            /*Console.WriteLine("**** REGISTRO DE MASCOTA ****\n");
            Console.Write("Ingrese el nombre de la 1ra mascota: ");
            m1.nombre = Console.ReadLine();
            Console.Write("Ingrese la edad de su mascota: ");
            m1.edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la especie de su mascota: ");
            m1.especie = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Ingrese el nombre de la 2da mascota: ");
            m2.nombre = Console.ReadLine();
            Console.Write("Ingrese la edad de su mascota: ");
            m2.edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la especie de su mascota: ");
            m2.especie = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Ingrese el nombre de la 3ra mascota: ");
            m3.nombre = Console.ReadLine();
            Console.Write("Ingrese la edad de su mascota: ");
            m3.edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la especie de su mascota: ");
            m3.especie = Console.ReadLine();
            */
            Console.Clear();
            Console.WriteLine("Mascotas registradas correctamente.\n\n");
        }
        public void EliminarM()
        {
            
            Console.Clear();
            Mascota m1 = new Mascota();
            Mascota m2 = new Mascota();
            Mascota m3 = new Mascota();

            Console.WriteLine("Mascotas:");
            Console.WriteLine($"1.  {m1.nombre}");
            Console.WriteLine($"2.  {m2.nombre}");
            Console.WriteLine($"3.  {m3.nombre}");
            Console.Write("Seleccione que mascota desea eliminar: ");
            Console.ReadLine();

            Console.WriteLine("Mascota eliminada correctamente del registro.");
        }
        public void ListarMascota()
        {
            Console.Clear();
            Mascota m1 = new Mascota();
            //Mascota m2 = new Mascota();
            //Mascota m3 = new Mascota();

            Console.WriteLine("**************** Lista de mascotas ****************\n");
            Console.WriteLine($"1. {m1.nombre}, de {m1.edad} año(s) - {m1.especie}");
            //Console.WriteLine($"2. {m2.nombre}, de {m2.edad} año(s) - {m2.especie}");
            //Console.WriteLine($"3. {m3.nombre}, de {m3.edad} año(s) - {m3.especie}");
            Console.WriteLine("\n***************************************************\n\n");
        }
    }
}
