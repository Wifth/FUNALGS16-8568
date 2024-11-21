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
        public static void CrearM()
        {
            int x = 0;
            Console.Write("Ingrese la cantidad de servicios: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Prueba");
            }

        }

        public static void EliminarM()
        {

        }
        public static void ListarMascota()
        {

        }
    }
}
