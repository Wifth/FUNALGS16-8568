using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Especie: {Especie}";
        }
        public void CrearM(List<Mascota> mascotas)
        {
            Console.Clear();

            Console.WriteLine("**** REGISTRO DE MASCOTA ****\n");
            Console.Write("Ingrese el NOMBRE de su mascota: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la EDAD de su mascota: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la ESPECIE de su mascota: ");
            string especie = Console.ReadLine();
            mascotas.Add(new Mascota { Nombre = nombre, Edad = edad, Especie = especie });
            Console.Clear();
            Console.WriteLine("Mascotas registradas correctamente.\n\n");
        }
        public void EliminarM(List<Mascota> mascotas)
        {
            Console.Clear();
            ListarMascota(mascotas);
            Console.Write("Ingrese el índice de la mascota a eliminar: ");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < mascotas.Count)
            {
                mascotas.RemoveAt(index);
                Console.WriteLine("Mascota eliminada con éxito.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }
        public void ListarMascota(List<Mascota> mascotas)
        {
            Console.Clear();
            if (mascotas.Count == 0)
            {
                Console.WriteLine("No hay mascotas registradas.");
            }
            else
            {
                Console.WriteLine("Mascotas:");
                for (int i = 0; i < mascotas.Count; i++)
                {
                    Console.WriteLine($"{i}: {mascotas[i]}");
                }
            }
        }
    }
}
