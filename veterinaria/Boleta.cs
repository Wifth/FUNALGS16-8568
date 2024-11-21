using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Boleta
    {
        public int codigo { get; set; }
        public Mascota mascota1 { get; set; }
        public Servicio servicio1 { get; set; }
        public Servicio servicio2 { get; set; }
        public int total { get; set; }
        public static void CrearB()
        {
            Console.Write("Ingrese la mascota: ");
            string mascota1 = Console.ReadLine();
            Console.Write("Ingrese el primer servicio: ");
            string servicio1 = Console.ReadLine();
            Console.Write("Ingrese el segundo servicio: ");
            string servicio2 = Console.ReadLine();
            Console.Write("Ingrese el precio total: ");
        }
        public static void ListarBoleta()
        {

        }
    }
}
