using System;

namespace MetodosBusqueda.Datos
{
    public static class GeneradorDatos
    {
        public static int[] Generar(int tamaño)
        {
            Random rnd = new Random();
            int[] arreglo = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
                arreglo[i] = rnd.Next(1, 100000);
            return arreglo;
        }
    }
}
