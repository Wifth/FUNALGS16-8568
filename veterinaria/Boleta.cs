using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria;
namespace veterinaria
{
    public class Boleta
    {
        public int Codigo { get; set; }
        public Mascota Mascota1 { get; set; }
        public Servicio Servicio1 { get; set; }
        public Servicio Servicio2 { get; set; }
        public decimal Total { get; set; }


        public override string ToString()
        {
            string servicios = Servicio2 != null ? $"{Servicio1.Descripcion}, {Servicio2.Descripcion}" : $"{Servicio1.Descripcion}";
            return $"Código: {Codigo}, Mascota: {Mascota1.Nombre}, Servicios: {servicios}, Total: ${Total}";
        }
        public void CrearB(List<Mascota> mascotas, List<Servicio> servicios, List<Boleta> boletas)
        {
            if (mascotas.Count == 0)
            {
                Console.WriteLine("No hay mascotas registradas.");
                return;
            }
            if (servicios.Count == 0)
            {
                Console.WriteLine("No hay servicios registrados.");
                return;
            }

            Console.WriteLine("\nSeleccione una mascota:");
            for (int i = 0; i < mascotas.Count; i++)
            {
                Console.WriteLine($"{i}: {mascotas[i].Nombre} ({mascotas[i].Especie})");
            }

            int mascotaIndex = int.Parse(Console.ReadLine());
            if (mascotaIndex < 0 || mascotaIndex >= mascotas.Count)
            {
                Console.WriteLine("Índice inválido.");
                return;
            }

            Mascota mascotaSeleccionada = mascotas[mascotaIndex];

            Console.WriteLine("\nSeleccione el primer servicio:");
            for (int i = 0; i < servicios.Count; i++)
            {
                Console.WriteLine($"{i}: {servicios[i].Descripcion} - ${servicios[i].Precio}");
            }

            int servicio1Index = int.Parse(Console.ReadLine());
            if (servicio1Index < 0 || servicio1Index >= servicios.Count)
            {
                Console.WriteLine("Índice inválido.");
                return;
            }

            Servicio servicio1Seleccionado = servicios[servicio1Index];

            Console.WriteLine("\nSeleccione el segundo servicio:");
            for (int i = 0; i < servicios.Count; i++)
            {
                Console.WriteLine($"{i}: {servicios[i].Descripcion} - ${servicios[i].Precio}");
            }

            int servicio2Index = int.Parse(Console.ReadLine());
            if (servicio2Index < 0 || servicio2Index >= servicios.Count)
            {
                Console.WriteLine("Índice inválido.");
                return;
            }

            Servicio servicio2Seleccionado = servicios[servicio2Index];

            decimal total = servicio1Seleccionado.Precio + servicio2Seleccionado.Precio;
            int codigo = boletas.Count + 1;

            boletas.Add(new Boleta
            {
                Codigo = codigo,
                Mascota1 = mascotaSeleccionada,
                Servicio1 = servicio1Seleccionado,
                Servicio2 = servicio2Seleccionado,
                Total = total
            });

            Console.WriteLine("Boleta creada exitosamente.");
        }
        public void ListarB(List<Boleta> boletas)
        {
            Console.WriteLine("\nBoleta registrada:\n");
            foreach (var boleta in boletas)
            {
                Console.WriteLine("************************************");
                Console.WriteLine($"    Código: BOL - {boleta.Codigo}");
                Console.WriteLine($"    Mascota: {boleta.Mascota1.Nombre} - Especie: {boleta.Mascota1.Especie}");
                Console.WriteLine($"    Servicio 1: {boleta.Servicio1.Descripcion} - ${boleta.Servicio1.Precio}");
                Console.WriteLine($"    Servicio 2: {boleta.Servicio2.Descripcion} - ${boleta.Servicio2.Precio}");
                Console.WriteLine($"    Total: ${boleta.Total}");
                Console.WriteLine("************************************");
            }
        }
    }
}
