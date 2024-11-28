using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Servicio
    {
        public string Descripcion {  get; set; }
        public decimal Precio { get; set; }
        public override string ToString()
        {
            return $"Descripción: {Descripcion}, Precio: ${Precio}";
        }

        public void CrearS(List<Servicio> servicios)
        {
            Console.Write("Ingrese la descripción del servicio: ");
            string descripcion = Console.ReadLine();
            Console.Write("Ingrese el precio del servicio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            servicios.Add(new Servicio { Descripcion = descripcion, Precio = precio });
            Console.WriteLine("Servicio creado con éxito.");

        }
        public void EliminarS(List<Servicio> servicios)
        {
            ListarServicio(servicios);
            Console.Write("Ingrese el índice del servicio a eliminar: ");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < servicios.Count)
            {
                servicios.RemoveAt(index);
                Console.WriteLine("Servicio eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }
        public void ListarServicio(List<Servicio> servicios)
        {
            if (servicios.Count == 0)
            {
                Console.WriteLine("No hay servicios registrados.");
            }
            else
            {
                Console.WriteLine("Servicios:");
                for (int i = 0; i < servicios.Count; i++)
                {
                    Console.WriteLine($"{i}: {servicios[i]}");
                }
            }
        }
    }
}
