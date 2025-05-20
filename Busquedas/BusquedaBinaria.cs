namespace MetodosBusqueda.Busquedas
{
    public static class BusquedaBinaria
    {
        public static int Buscar(int[] arreglo, int objetivo)
        {
            int izquierda = 0, derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (arreglo[medio] == objetivo)
                    return medio;
                else if (arreglo[medio] < objetivo)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }

            return -1;
        }
    }
}
