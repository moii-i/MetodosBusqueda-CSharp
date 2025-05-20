using System;

namespace MetodosBusqueda.Busquedas
{
    public static class TransformacionClaves
    {
        public static int Buscar(int[] arreglo, int objetivo)
        {
            int tamaño = arreglo.Length;
            int[] tabla = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                int clave = Hash(arreglo[i], tamaño);
                tabla[clave] = arreglo[i];
            }

            int claveObjetivo = Hash(objetivo, tamaño);
            return tabla[claveObjetivo] == objetivo ? claveObjetivo : -1;
        }

        private static int Hash(int clave, int tamaño)
        {
            return Math.Abs(clave % tamaño);
        }
    }
}
