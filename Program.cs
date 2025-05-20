using System;
using MetodosBusqueda.Busquedas;
using MetodosBusqueda.Utilidades;
using MetodosBusqueda.Datos;

class Program
{
    static void Main()
    {
        int[] datos = GeneradorDatos.Generar(100000); // Cambia a 10 o 1000 para pruebas pequeñas
        int objetivo = datos[new Random().Next(datos.Length)];

        Console.WriteLine("Métodos de Búsqueda en C#");
        Console.WriteLine("1. Búsqueda Secuencial");
        Console.WriteLine("2. Búsqueda Binaria");
        Console.WriteLine("3. Búsqueda por Transformación de Claves");
        Console.Write("Selecciona una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        int resultado = -1;
        long tiempo = Cronometro.MedirTiempo(() =>
        {
            switch (opcion)
            {
                case 1:
                    resultado = BusquedaSecuencial.Buscar(datos, objetivo);
                    break;
                case 2:
                    Array.Sort(datos); // Pre-requisito para búsqueda binaria
                    resultado = BusquedaBinaria.Buscar(datos, objetivo);
                    break;
                case 3:
                    resultado = TransformacionClaves.Buscar(datos, objetivo);
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        });

        Console.WriteLine(resultado >= 0
            ? $"Elemento encontrado en el índice {resultado}"
            : "Elemento no encontrado");

        Console.WriteLine($"Tiempo de ejecución: {tiempo} ms");
    }
}
